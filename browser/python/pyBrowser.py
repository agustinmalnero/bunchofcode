import sys, re
from PyQt4 import QtGui, QtCore, QtWebKit

class PyBrowser(QtGui.QWidget):

    def __init__(self):
        QtGui.QWidget.__init__(self)
        self.setWindowTitle('Simple Web Browser')
        
        v_box = QtGui.QVBoxLayout(self)
        #Navigation Bar
        h_bar = QtGui.QHBoxLayout()
        self.previous = QtGui.QPushButton(self.style().standardIcon(QtGui.QStyle.SP_ArrowLeft), '')
        self.next = QtGui.QPushButton(self.style().standardIcon(QtGui.QStyle.SP_ArrowRight), '')
        self.refresh = QtGui.QPushButton(self.style().standardIcon(QtGui.QStyle.SP_BrowserReload), '')
        self.stop = QtGui.QPushButton(self.style().standardIcon(QtGui.QStyle.SP_BrowserStop), '')
        self.url = QtGui.QLineEdit('')
        self.url.setFixedWidth(550)
        self.okUrl = QtGui.QPushButton(self.style().standardIcon(QtGui.QStyle.SP_DialogOkButton), '')
        self.okUrl.setFlat(True)
        h_bar.addWidget(self.previous)
        h_bar.addWidget(self.next)
        h_bar.addWidget(self.refresh)
        h_bar.addWidget(self.stop)
        h_bar.addWidget(self.url)
        h_bar.addWidget(self.okUrl)
        #Page Frame
        self.web = QtWebKit.QWebView()
        self.web.load(QtCore.QUrl('http://www.google.com'))
        #Status Bar
        self.status = QtGui.QStatusBar()
        self.prog = QtGui.QProgressBar()
        self.load = QtGui.QLabel('Loading...')
        self.status.addWidget(self.load)
        self.status.addWidget(self.prog)

        #Add widgets and layout to window
        v_box.addLayout(h_bar)
        v_box.addWidget(self.web)
        v_box.addWidget(self.status)
        #Shortcut
        self.short = QtGui.QShortcut(QtGui.QKeySequence(QtCore.Qt.CTRL + QtCore.Qt.Key_J), self.url)

        self.connect(self.previous, QtCore.SIGNAL("clicked()"), self.web.back)
        self.connect(self.next, QtCore.SIGNAL("clicked()"), self.web.forward)
        self.connect(self.refresh, QtCore.SIGNAL("clicked()"), self.web.reload)
        self.connect(self.stop, QtCore.SIGNAL("clicked()"), self.web.stop)
        self.connect(self.url, QtCore.SIGNAL("returnPressed()"), self.doSearch)
        self.connect(self.okUrl, QtCore.SIGNAL("clicked()"), self.doSearch)
        self.connect(self.web, QtCore.SIGNAL("loadProgress(int)"), self.progress)
        self.connect(self.web, QtCore.SIGNAL("loadFinished(bool)"), self.loadComplete)
        self.connect(self.web, QtCore.SIGNAL("loadStarted()"), self.status.show)
        self.connect(self.short, QtCore.SIGNAL("activated()"), self.url.setFocus)

    def progress(self, porc):
        self.prog.setValue(porc)

    def openUrl(self, text):
        self.web.setFocus()
        self.web.load(QtCore.QUrl(text))

    def doSearch(self):
        link = self.url.text()
        pat = re.compile('(.+)\\.(.+)')
        patHttp = re.compile('^http://')
        if pat.match(link) and not patHttp.match(link):
            link = 'http://' + link
        elif not pat.match(link):
            link = 'http://www.google.com/search?q=' + link.replace(' ', '+')
        self.openUrl(link)

    def loadComplete(self):
        self.url.setText(self.web.url().toString())
        self.status.hide()


app = QtGui.QApplication(sys.argv)
pybrowser = PyBrowser()
pybrowser.show()

sys.exit(app.exec_())
