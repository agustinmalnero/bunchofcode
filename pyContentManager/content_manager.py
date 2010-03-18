import re
from PyQt4 import QtGui
from datetime import datetime

class ContentManager:

    def __init__(self, page=None):
        try:
            if page == None:
                h = open('model/header.html', 'r')
                f = open('model/footer.html', 'r')
                c = open('model/content.html', 'r')
                self.header = h.read()
                self.footer = f.read()
                self.template = c.read()
                self.contents = []
                self.text = ''
        except:
            print 'No se pudo encontrar alguno de los archivos'

    def addContent(self, title, post, content):
        contentTemplate = self.template.replace('[TITULOPOST]', title)
        if post == '':
            t = datetime.now()
            contentTemplate = contentTemplate.replace('[POSTINFO]', t.strftime('%d/%m/%Y'))
        else:
            contentTemplate = contentTemplate.replace('[POSTINFO]', post)
        for p in content:
            if p.find('<img') != -1:
                img = p.split('"')
                p = img[0] + '"http://teatroindicios.com.ar/fotos/' + img[1].split('/')[-1] + '" alt="" />'
            self.text += '<p>'+p+'</p>' if p != '' else ''
        contentTemplate = contentTemplate.replace('<p>[TEXTOPOST]</p>', self.text)
        self.contents.append(contentTemplate)
        self.text = ''

    def createPage(self):
        filename = QtGui.QFileDialog.getSaveFileName()
        if(filename != ''):
            page = open(str(filename), 'w')
            page.write(self.header)
            for p in self.contents:
                page.write(p)
            page.write(self.footer)
            page.close()
            QtGui.QMessageBox.information(None, 'Nueva Pagina', 'La Pagina se creo Correctamente', 'Aceptar')

    def createPageWithFile(self, filename):
        if(filename != ''):
            page = open(str(filename), 'w')
            page.write(self.header)
            for p in self.contents:
                page.write(p)
            page.write(self.footer)
            page.close()
            QtGui.QMessageBox.information(None, 'Pagina Guardada', 'La Pagina se guardo Correctamente', 'Aceptar')
