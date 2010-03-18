import sys
from PyQt4 import QtGui, QtCore
import edit_page
from BeautifulSoup import BeautifulSoup

class Indicios(QtGui.QMainWindow):

    def __init__(self):
        QtGui.QMainWindow.__init__(self)
        self.setWindowTitle('Gestor de Contenidos: Pagina INDICIOS')
        self.setWindowIcon(QtGui.QIcon('img/mascara.jpg'))
        self.background = QtGui.QLabel()
        pixmap = QtGui.QPixmap('img/indicios.png')
        self.background.setPixmap(pixmap)

        h_box = QtGui.QHBoxLayout()
        h_box.addWidget(self.background)
        central = QtGui.QWidget()
        central.setLayout(h_box)
        self.setCentralWidget(central)

        toolbar = QtGui.QToolBar()
        toolbar.setFloatable(False)
        modificar = QtGui.QAction('Editar Pagina', toolbar)
        integrante = QtGui.QAction('Agregar Integrante', toolbar)
        libreto = QtGui.QAction('Nuevo Libreto', toolbar)
        toolbar.addAction(modificar)
        toolbar.addSeparator()
        toolbar.addAction(integrante)
        toolbar.addSeparator()
        toolbar.addAction(libreto)
        self.addToolBar(toolbar)

        modifyPage = edit_page.EditPage()
        QtCore.QObject.connect(modificar, QtCore.SIGNAL("triggered()"), lambda: modifyPage.show())


app = QtGui.QApplication(sys.argv)
indicios = Indicios()
indicios.show()

sys.exit(app.exec_())
