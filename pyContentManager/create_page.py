from PyQt4 import QtGui, QtCore
import content_manager

class CreatePage(QtGui.QMainWindow):

    def __init__(self):
        QtGui.QMainWindow.__init__(self)
        self.setWindowTitle('Crear Nueva Pagina')
        self.setWindowIcon(QtGui.QIcon('img/mascara.jpg'))
        self.resize(300, 400)
        self.label = QtGui.QLabel('Ingrese el contenido que tendra el primer Post de esta Pagina.')
        self.lblTitle = QtGui.QLabel('Titulo')
        self.title = QtGui.QLineEdit()
        self.lblInfo = QtGui.QLabel('Post Info:')
        self.txtInfo = QtGui.QLineEdit()
        self.txtInfo.setToolTip('Si se deja vacio se colocara por defecto la Fecha del Dia')
        self.lblContent = QtGui.QLabel('Contenido')
        self.content = QtGui.QPlainTextEdit()

        h_box = QtGui.QHBoxLayout()
        h_box.addWidget(self.lblTitle)
        h_box.addWidget(self.title)
        v_box = QtGui.QVBoxLayout()
        v_box.addWidget(self.lblInfo)
        v_box.addWidget(self.txtInfo)
        v_box.addWidget(self.lblContent)
        v_box.addWidget(self.content)

        grid = QtGui.QGridLayout()
        grid.addWidget(self.label, 0, 0, QtCore.Qt.AlignCenter)
        grid.addLayout(h_box, 1, 0, QtCore.Qt.AlignCenter)
        grid.addLayout(v_box, 2, 0, QtCore.Qt.AlignCenter)

        central_widget = QtGui.QWidget()
        central_widget.setLayout(grid)
        self.setCentralWidget(central_widget)
        
        self.toolbar = QtGui.QToolBar()
        self.toolbar.setFloatable(False)
        self.toolbar.setMovable(False)
        crear = QtGui.QAction('Crear', self.toolbar)
        self.toolbar.addAction(crear)
        self.addToolBar(self.toolbar)

        QtCore.QObject.connect(crear, QtCore.SIGNAL("triggered()"), self.generar)

    def generar(self):
        manager = content_manager.ContentManager()
        manager.addContent(self.title.text(), self.txtInfo.text(), self.content.toPlainText())
        manager.createPage()
