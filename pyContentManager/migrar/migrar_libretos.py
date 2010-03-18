# -*- coding: utf-8 -*-

import os, sys, re
from BeautifulSoup import BeautifulSoup
import post, content_manager

class Migrar:

    def __init__(self, archivo):
        raiz = str(archivo)
        salida = open('/home/gato/libretos.txt', 'w')
        for name in os.listdir(raiz):
            try:
                f = open(raiz+name)
                destino = '/media/GATO/programacion/html/indicios/libretos/'
                html = f.read()
                f.close()
                html = html.replace(u'ñ', '&ntilde;').replace(u'Ñ', '&Ntilde;')
                html = html.replace(u'á', '&aacute;').replace(u'Á', '&Aacute;')
                html = html.replace(u'é', '&eacute;').replace(u'É', '&Eacute;')
                html = html.replace(u'í', '&iacute;').replace(u'Í', '&Iacute;')
                html = html.replace(u'ó', '&oacute;').replace(u'Ó', '&Oacute;')
                html = html.replace(u'ú', '&uacute;').replace(u'Ú', '&Uacute;')
                soup = BeautifulSoup(html)
                text = soup.findAll('font', {'face':'Courier New, Courier, mono', 'size':'2'})
                s = ''
                for p in text:
                    s += ''.join(p.findAll(text=True))
                s = s.replace('\r\n', '')
                s = s.replace('    ', '')                    
                array = [s]

                personajes = soup.findAll('i')
                i = personajes[0].findAll(text=True)[0]
                array.append('<i>'+i+'</i>:')

                array.append('Solicitud de Libretos a: <a href="mailto:teatroindicios@yahoo.com.ar">teatroindicios@yahoo.com.ar</a>')

                genero = 'GENERO'

                newPost = post.Post('Titulo Obra', genero, array)
                fileName = name.split('.')[0] + '.html'
                manager = content_manager.ContentManager()
                manager.addContent(newPost.title, newPost.info, newPost.content)
                manager.createPageWithFile(destino+fileName)
            except:
                print raiz+name
                array = ['Resumen', '<i>Personajes: </i>']
                array.append('Solicitud de Libretos a: <a href="mailto:teatroindicios@yahoo.com.ar">teatroindicios@yahoo.com.ar</a>')
                newPost = post.Post('Titulo Obra', 'GENERO', array)
                fileName = name.split('.')[0] + '.html'
                manager = content_manager.ContentManager()
                manager.addContent(newPost.title, newPost.info, newPost.content)
                manager.createPageWithFile(destino+fileName)
                salida.write(raiz+name+'\n')
        salida.close()


if __name__ == '__main__':
    migrar = Migrar(sys.argv[1])

