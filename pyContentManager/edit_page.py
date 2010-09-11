# -*- coding: utf-8 -*-

import re
from PyQt4 import QtGui, QtCore
from BeautifulSoup import BeautifulSoup
import post, content_manager

class EditPage(QtGui.QMainWindow):

    def __init__(self):
        QtGui.QMainWindow.__init__(self)
        self.posts = []
        self.videos = []
        self.modification = False
        self.modifyPos = -1
        self.setWindowTitle('Editar Pagina')
        self.setWindowIcon(QtGui.QIcon('img/mascara.jpg'))
        self.resize(800, 500)
        self.pageModify = False

        toolbar = QtGui.QToolBar()
        toolbar.setMovable(False)
        toolbar.setFloatable(False)
        nuevo = QtGui.QAction('Nuevo', toolbar)
        abrir = QtGui.QAction('Abrir', toolbar)
        guardar = QtGui.QAction(QtGui.QIcon('img/save.png'), 'Guardar', toolbar)
        guardarComo = QtGui.QAction(QtGui.QIcon('img/guardar-como.png'), 'Guardar Como', toolbar)
        undo = QtGui.QAction(QtGui.QIcon('img/undo.png'), '', toolbar)
        redo = QtGui.QAction(QtGui.QIcon('img/redo.png'), '', toolbar)
        toolbar.addAction(nuevo)
        toolbar.addSeparator()
        toolbar.addAction(abrir)
        toolbar.addSeparator()
        toolbar.addAction(guardar)
        toolbar.addAction(guardarComo)
        toolbar.addSeparator()
        toolbar.addAction(undo)
        toolbar.addAction(redo)
        self.addToolBar(toolbar)

        '''Interfaz de la Ventana'''
        grid = QtGui.QGridLayout()
        labelHeader = QtGui.QLabel('Nombre Pagina:')
        self.labelNombre = QtGui.QLabel()
        lblTitle = QtGui.QLabel('Titulo')
        self.title = QtGui.QLineEdit()
        lblInfo = QtGui.QLabel('Post Info:')
        self.txtInfo = QtGui.QLineEdit()
        self.txtInfo.setToolTip('Si se deja vacio se colocara por defecto la Fecha del Dia')
        lblContent = QtGui.QLabel('Contenido')
        self.content = QtGui.QTextEdit()

        '''BOTONES'''
        btnImage = QtGui.QPushButton(QtGui.QIcon('img/image.png'), '')
        btnVideo = QtGui.QPushButton(QtGui.QIcon('img/multimedia.png'), '')
        btnVideo.setToolTip('Video/Diapositivas')
        btnBold = QtGui.QPushButton(QtGui.QIcon('img/bold.png'), '')
        btnItalic = QtGui.QPushButton(QtGui.QIcon('img/italic.png'), '')
        btnLink = QtGui.QPushButton(QtGui.QIcon('img/link.png'), '')
        btnPost = QtGui.QPushButton(QtGui.QIcon('img/addPost.png'), '')
        btnActive = QtGui.QPushButton(QtGui.QIcon('img/active.png'), '')
        btnAdd = QtGui.QPushButton(QtGui.QIcon('img/add.png'), '')
        btnRemove = QtGui.QPushButton(QtGui.QIcon('img/remove.png'), '')
        btnUp = QtGui.QPushButton(QtGui.QIcon('img/up.png'), '')
        btnDown = QtGui.QPushButton(QtGui.QIcon('img/down.png'), '')
        '''BUTTONS SIGNALS'''
        QtCore.QObject.connect(nuevo, QtCore.SIGNAL("triggered()"), self.newFile)
        QtCore.QObject.connect(abrir, QtCore.SIGNAL("triggered()"), self.openFile)
        QtCore.QObject.connect(guardar, QtCore.SIGNAL("triggered()"), self.saveFile)
        QtCore.QObject.connect(guardarComo, QtCore.SIGNAL("triggered()"), self.saveFileAs)
        QtCore.QObject.connect(undo, QtCore.SIGNAL("triggered()"), self.undoEdit)
        QtCore.QObject.connect(redo, QtCore.SIGNAL("triggered()"), self.redoEdit)
        QtCore.QObject.connect(btnBold, QtCore.SIGNAL("clicked()"), self.insertBold)
        QtCore.QObject.connect(btnItalic, QtCore.SIGNAL("clicked()"), self.insertItalic)
        QtCore.QObject.connect(btnLink, QtCore.SIGNAL("clicked()"), self.insertLink)
        QtCore.QObject.connect(btnVideo, QtCore.SIGNAL("clicked()"), self.insertVideo)
        QtCore.QObject.connect(btnImage, QtCore.SIGNAL("clicked()"), self.insertImage)
        QtCore.QObject.connect(btnActive, QtCore.SIGNAL("clicked()"), self.setCurrent)
        QtCore.QObject.connect(btnAdd, QtCore.SIGNAL("clicked()"), self.newPost)
        QtCore.QObject.connect(btnRemove, QtCore.SIGNAL("clicked()"), self.removeItem)
        QtCore.QObject.connect(btnUp, QtCore.SIGNAL("clicked()"), self.moveUp)
        QtCore.QObject.connect(btnDown, QtCore.SIGNAL("clicked()"), self.moveDown)
        QtCore.QObject.connect(btnPost, QtCore.SIGNAL("clicked()"), self.addNewPost)

        self.listWidget = QtGui.QListWidget()

        '''LAYOUTS'''
        h_box = QtGui.QHBoxLayout()
        h_box2 = QtGui.QHBoxLayout()
        h_box.addWidget(labelHeader)
        h_box.addWidget(self.labelNombre)
        h_box2.addWidget(lblTitle)
        h_box2.addWidget(self.title)
        v_box = QtGui.QVBoxLayout()
        v_box.addWidget(lblInfo)
        v_box.addWidget(self.txtInfo)
        v_box.addWidget(lblContent)
        v_box.addWidget(self.content)
        h_box3 = QtGui.QHBoxLayout()
        h_box3.addWidget(btnImage)
        h_box3.addWidget(btnVideo)
        h_box3.addWidget(btnBold)
        h_box3.addWidget(btnItalic)
        h_box3.addWidget(btnLink)
        h_box3.addWidget(btnPost)
        h_box4 = QtGui.QHBoxLayout()
        h_box4.addWidget(btnActive)
        h_box4.addWidget(btnAdd)
        h_box4.addWidget(btnRemove)
        h_box4.addWidget(btnUp)
        h_box4.addWidget(btnDown)

        grid.addLayout(h_box, 0, 0, QtCore.Qt.AlignCenter)
        grid.addLayout(h_box2, 1, 0, QtCore.Qt.AlignCenter)
        grid.addLayout(v_box, 2, 0, QtCore.Qt.AlignCenter)
        grid.addWidget(self.listWidget, 2, 1, QtCore.Qt.AlignCenter)
        grid.addLayout(h_box3, 3, 0, QtCore.Qt.AlignCenter)
        grid.addLayout(h_box4, 3, 1, QtCore.Qt.AlignCenter)

        central_widget = QtGui.QWidget()
        central_widget.setLayout(grid)
        self.setCentralWidget(central_widget)

    def openFile(self):
        self.filename = QtGui.QFileDialog.getOpenFileName()
        name = self.filename.split('/')
        self.labelNombre.setText(name[-1])
        f = open(self.filename, 'r')
        html = f.read()
        f.close()
        self.listWidget.clear()
        self.posts = []
        self.newPost()
        self.parseHtml(html)
        self.pageModify = True

    def parseHtml(self, htmlFile):
        soup = BeautifulSoup(htmlFile)
        column_two = soup.findAll('div', {'class':'column_two_section'})
        for p in column_two:
            title = [''.join(p.findAll('h1')[0].findAll(text=True))][0]
            info = [''.join(p.findAll('div', {'class':'post_info'})[0].findAll(text=True))][0]
            content = [str(beauti) for beauti in p.findAll('p')]
            self.posts.append(post.Post(title, info, content))
            self.listWidget.addItem(title)

    def insertBold(self):
        result, valid = QtGui.QInputDialog.getText(self, 'Texto', 'Ingrese el texto a colocar en Negrita:')
        self.content.insertHtml(' <strong>'+result+'</strong> ')
        self.content.setFocus()

    def insertItalic(self):
        result, valid = QtGui.QInputDialog.getText(self, 'Texto', 'Ingrese el texto a colocar en Cursiva:')
        self.content.insertHtml(' <i>'+result+'</i> ')
        self.content.setFocus()

    def insertLink(self):
        result, valid = QtGui.QInputDialog.getText(self, 'Texto', 'Ingrese el texto a colocar como link:')
        result2, valid2 = QtGui.QInputDialog.getText(self, 'Link', 'Ingrese el link:', QtGui.QLineEdit.Normal, 'http://')
        self.content.insertHtml(' <a href="'+result2+'">'+result+'</a> ')
        self.content.setFocus()

    def insertImage(self):
        name = QtGui.QFileDialog.getOpenFileName()
        self.content.insertHtml('<img src="'+name+'" alt="" />')
        self.content.insertPlainText('\n')
        self.content.setFocus()

    def setCurrent(self):
        postActive = self.posts[self.listWidget.currentRow()]
        self.modification = True
        self.modifyPos = self.listWidget.currentRow()
        self.title.setText(postActive.title)
        self.txtInfo.setText(postActive.info)
        self.content.clear()
        for p in postActive.content:
            self.content.insertHtml(p)
            self.content.insertPlainText('\n')

    def newPost(self):
        self.modification = False
        self.modifyPos = -1
        self.title.setText('')
        self.txtInfo.setText('')
        self.content.clear()
        self.title.setFocus()

    def removeItem(self):
        self.posts.pop(self.listWidget.currentRow())
        self._loadList()

    def _loadList(self):
        self.listWidget.clear()
        for p in self.posts:
            self.listWidget.addItem(p.title)

    def moveUp(self):
        n = self.listWidget.currentRow()
        self.posts[n], self.posts[n-1] = self.posts[n-1], self.posts[n]
        self._loadList()
        self.listWidget.setCurrentRow(n-1)

    def moveDown(self):
        n = self.listWidget.currentRow()
        self.posts[n], self.posts[n+1] = self.posts[n+1], self.posts[n]
        self._loadList()
        self.listWidget.setCurrentRow(n+1)

    def undoEdit(self):
        self.content.undo()

    def redoEdit(self):
        self.content.redo()

    def addNewPost(self):
        title = self.title.text()
        info = self.txtInfo.text()
        title = title.replace(u'ñ', '&ntilde;').replace(u'Ñ', '&Ntilde;')
        title = title.replace(u'á', '&aacute;').replace(u'Á', '&Aacute;')
        title = title.replace(u'é', '&eacute;').replace(u'É', '&Eacute;')
        title = title.replace(u'í', '&iacute;').replace(u'Í', '&Iacute;')
        title = title.replace(u'ó', '&oacute;').replace(u'Ó', '&Oacute;')
        title = title.replace(u'ú', '&uacute;').replace(u'Ú', '&Uacute;')
        info = info.replace(u'ñ', '&ntilde;').replace(u'Ñ', '&Ntilde;')
        info = info.replace(u'á', '&aacute;').replace(u'Á', '&Aacute;')
        info = info.replace(u'é', '&eacute;').replace(u'É', '&Eacute;')
        info = info.replace(u'í', '&iacute;').replace(u'Í', '&Iacute;')
        info = info.replace(u'ó', '&oacute;').replace(u'Ó', '&Oacute;')
        info = info.replace(u'ú', '&uacute;').replace(u'Ú', '&Uacute;')

        html = self.content.toHtml().replace(u'ñ', '&ntilde;').replace(u'Ñ', '&Ntilde;')
        html = html.replace(u'á', '&aacute;').replace(u'Á', '&Aacute;')
        html = html.replace(u'é', '&eacute;').replace(u'É', '&Eacute;')
        html = html.replace(u'í', '&iacute;').replace(u'Í', '&Iacute;')
        html = html.replace(u'ó', '&oacute;').replace(u'Ó', '&Oacute;')
        html = html.replace(u'ú', '&uacute;').replace(u'Ú', '&Uacute;')
        html = str(html.toUtf8())
        html = html.replace('<span style=" font-weight:600;">', '<strong>')
        html = html.replace('<span style=" font-style:italic;">', '<i>')
        html = html.replace('<span style=" text-decoration: underline; color:#0000ff;">', '<link>')
        pos = 0            
        while html.find('</span>', pos) != -1:
            nB = html.find('<strong>', pos)
            nB = nB if nB != -1 else len(html)
            nI = html.find('<i>', pos)
            nI = nI if nI != -1 else len(html)
            nL = html.find('<link>', pos)
            nL = nL if nL != -1 else len(html)

            if nB == -1 and nI == -1 and nL == -1:
                html = html.replace('</span>', '')
            elif nB < nI and nB < nL:
                html = html.replace('</span>', '</strong>', 1)
                pos = nB+1
            elif nI < nB and nI < nL:
                html = html.replace('</span>', '</i>', 1)
                pos = nI+1
            else:
                html = html.replace('</span>', '', 1)
                html = html.replace('<link>', '', 1)
        for v in self.videos:
            html = html.replace('[VIDEO]', v, 1)
        soup = BeautifulSoup(html)
        reg = re.compile('<p style=(.+);">')
        paragraphs = []
        for p in soup.findAll('p'):
            c = str(p)
            c = reg.sub('', c)
            c = c.replace('<p></p>', '')
            c = c.replace('</p>', '')
            paragraphs.append(c.decode('utf-8'))
        if self.modification:
            self.posts[self.modifyPos] = post.Post(title, info, paragraphs)
        else:
            self.posts.append(post.Post(title, info, paragraphs))
        self._loadList()
        self.newPost()

    def saveFile(self):
        if self.pageModify:
            manager = content_manager.ContentManager()
            for post in self.posts:
                manager.addContent(post.title, post.info, post.content)
            manager.createPageWithFile(self.filename)
        else:
            self.saveFileAs()

    def saveFileAs(self):
        manager = content_manager.ContentManager()
        for post in self.posts:
            manager.addContent(post.title, post.info, post.content)
        manager.createPage()

    def newFile(self):
        self.posts = []
        self.pageModify = False
        self.videos = []
        self.listWidget.clear()
        self.newPost()
        self.labelNombre.setText('')

    def insertVideo(self):
        result, valid = QtGui.QInputDialog.getText(self, 'Texto', 'Ingrese el Video/Diapositivas:')
        self.content.insertHtml('[VIDEO]')
        self.content.insertPlainText('\n')
        self.videos.append(result)
        self.content.setFocus()
