import sys, os, threading
from PyQt4 import QtGui, QtCore

class SimpleConverter(QtGui.QWidget):

    def __init__(self):
        QtGui.QWidget.__init__(self)
        self.setWindowTitle('Simple Converter')
        self.fromFile = ''
        self.toFile = ''
        self.subsFile = ''
        self.folder = '.'
        
        v_box = QtGui.QVBoxLayout(self)
        #Configure
        h_conf = QtGui.QHBoxLayout()
        h_conf.addWidget(QtGui.QLabel('Desde:'))
        self.combo1 = QtGui.QComboBox()
        self.combo1.addItems(['AVI', 'RMVB'])
        h_conf.addWidget(self.combo1)
        self.checkSub = QtGui.QCheckBox('Agregar Subtitulos')
        h_conf.addWidget(QtGui.QLabel(' + '))
        h_conf.addWidget(self.checkSub)
        h_conf.addWidget(QtGui.QLabel(' = '))
        h_conf.addWidget(QtGui.QLabel('Convertir en:'))
        self.combo2 = QtGui.QComboBox()
        self.combo2.addItems(['AVI', 'RMVB'])
        h_conf.addWidget(self.combo2)
        #Avi Section
        self.textFrom = QtGui.QLineEdit('')
        self.textFrom.setFixedWidth(330)
        self.textFrom.setReadOnly(True)
        self.btnFrom = QtGui.QPushButton(self.style().standardIcon(QtGui.QStyle.SP_FileIcon), 'Video')
        self.btnFrom.setFixedWidth(130)
        h_boxAvi = QtGui.QHBoxLayout()
        h_boxAvi.addWidget(self.textFrom)
        h_boxAvi.addWidget(self.btnFrom)
        #rmvb Section
        self.textTo = QtGui.QLineEdit('')
        self.textTo.setFixedWidth(330)
        self.textTo.setReadOnly(True)
        self.btnTo = QtGui.QPushButton('Guardar como...')
        self.btnTo.setFixedWidth(130)
        h_boxRmvb = QtGui.QHBoxLayout()
        h_boxRmvb.addWidget(self.textTo)
        h_boxRmvb.addWidget(self.btnTo)
        #Subtitles
        self.textSubs = QtGui.QLineEdit('')
        self.textSubs.setFixedWidth(330)
        self.textSubs.setReadOnly(True)
        self.btnSubs = QtGui.QPushButton(self.style().standardIcon(QtGui.QStyle.SP_FileDialogDetailedView), 'Subtitulos')
        self.btnSubs.setFixedWidth(130)
        h_subs = QtGui.QHBoxLayout()
        h_subs.addWidget(self.textSubs)
        h_subs.addWidget(self.btnSubs)
        #Slider
        self.slider = QtGui.QSlider(QtCore.Qt.Horizontal)
        self.slider.setMinimum(0)
        self.slider.setMaximum(20)
        self.slider.setValue(10)
        self.lblSlider = QtGui.QLabel('3.0')
        h_slider = QtGui.QHBoxLayout()
        h_slider.addWidget(QtGui.QLabel('Escala Subtitulos:'))
        h_slider.addWidget(self.slider)
        h_slider.addWidget(self.lblSlider)
        #Convert
        self.btnConvert = QtGui.QPushButton(self.style().standardIcon(QtGui.QStyle.SP_ArrowDown), 'Convert')
        self.txtEdit = QtGui.QTextEdit()
        self.txtEdit.setReadOnly(True)
        #Add elements to Vertical Layout
        v_box.addWidget(QtGui.QLabel('Seleccione el Tipo de Conversion:'))
        v_box.addLayout(h_conf)
        v_box.addLayout(h_boxAvi)
        v_box.addLayout(h_subs)
        v_box.addLayout(h_slider)
        v_box.addLayout(h_boxRmvb)
        v_box.addWidget(self.btnConvert)
        v_box.addWidget(self.txtEdit)
        
        self.addSubs(0)
        
        self.connect(self.btnFrom, QtCore.SIGNAL("clicked()"), self.openfromFile)
        self.connect(self.btnSubs, QtCore.SIGNAL("clicked()"), self.openSubs)
        self.connect(self.btnTo, QtCore.SIGNAL("clicked()"), self.saveAs)
        self.connect(self.btnConvert, QtCore.SIGNAL("clicked()"), self.convertFormat)
        self.connect(self.checkSub, QtCore.SIGNAL("stateChanged(int)"), self.addSubs)
        self.connect(self.slider, QtCore.SIGNAL("valueChanged(int)"), self.slideChange)
        
    def slideChange(self, val):
        if val > 0:
            val = 2 + (float(val)/10)
        else:
            val = 2.0
        self.lblSlider.setText(str(val))
        
    def openfromFile(self):
        extension = '*.' + str(self.combo1.currentText()).lower()
        self.fromFile = str(QtGui.QFileDialog.getOpenFileName(self, 'Seleccione el archivo de video', self.folder, extension))
        pathFile = os.path.split(self.fromFile)
        self.folder = pathFile[0]
        self.textFrom.setText(pathFile[1])

    def openSubs(self):
        self.subsFile = str(QtGui.QFileDialog.getOpenFileName(self, 'Seleccione el archivo del Subtitulo', self.folder, '*.srt'))
        self.textSubs.setText(os.path.split(self.subsFile)[1])
        
    def saveAs(self):
        extension = '*.' + str(self.combo2.currentText()).lower()
        self.toFile = str(QtGui.QFileDialog.getSaveFileName(self, 'Seleccione el archivo AVI', self.folder, extension))
        if not self.toFile.endswith(extension[1:]):
            self.toFile += extension[1:]
        self.textTo.setText(os.path.split(self.toFile)[1])
        
    def convertFormat(self):
        self.txtEdit.clear()
        conver = Convert(self)
        conver.start()
        
    def addSubs(self, val):
        if val == 2:
            self.btnSubs.setEnabled(True)
            self.slider.setEnabled(True)
        else:
            self.btnSubs.setEnabled(False)
            self.slider.setEnabled(False)
            self.textSubs.setText('')
        


class Convert(threading.Thread):

    def __init__(self, sim):
        threading.Thread.__init__(self)
        self.simple = sim

    def run(self):
        #Descativar Interfaz
        self.simple.btnFrom.setEnabled(False)
        self.simple.btnTo.setEnabled(False)
        self.simple.slider.setEnabled(False)
        self.simple.btnSubs.setEnabled(False)
        self.simple.btnConvert.setEnabled(False)
        #Process
        self.simple.fromFile = self.simple.fromFile if self.simple.fromFile.find(' ') == -1 else '"'+self.simple.fromFile+'"'
        self.simple.subsFile = self.simple.subsFile if self.simple.subsFile.find(' ') == -1 else '"'+self.simple.subsFile+'"'
        self.simple.toFile = self.simple.toFile if self.simple.toFile.find(' ') == -1 else '"'+self.simple.toFile+'"'
        bash = 'mencoder ' + self.simple.fromFile
        if len(str(self.simple.textSubs.text())) > 0:
            print 'agregando subtitulos'
            bash += ' -sub ' + self.simple.subsFile + ' subfont-text-scale ' + str(self.simple.lblSlider.text())
        if str(self.simple.combo1.currentText()) == str(self.simple.combo2.currentText()):
            print 'Copiar formato video'
            bash += ' -ovc copy -oac copy -o ' + self.simple.toFile
        elif str(self.simple.combo1.currentText()) == 'RMVB' and str(self.simple.combo2.currentText()) == 'AVI':
            print 'RMVB -> AVI'
            bash += ' -ovc xvid -oac mp3lame -o ' + self.simple.toFile
        else:
            print 'AVI -> RMVB'
            bash += ' -ovc lavc -oac mp3lame -o ' + self.simple.toFile
        print bash
        self.simple.txtEdit.append('PROCESANDO...')
        try:
            f = os.popen(bash)
            for i in f.readlines():
                self.simple.txtEdit.append(i)
            self.simple.txtEdit.append('CONVERSION EXITOSA!')
        except:
            self.simple.txtEdit.append('HA OCURRIDO UN ERROR EN LA CONVERSION')
            self.simple.txtEdit.append('POR FAVOR VUELVA A INTENTARLO...')
        finally:
            self.simple.btnFrom.setEnabled(True)
            self.simple.btnTo.setEnabled(True)
            self.simple.slider.setEnabled(True)
            self.simple.btnSubs.setEnabled(True)
            self.simple.btnConvert.setEnabled(True)
        
        
app = QtGui.QApplication(sys.argv)
simple = SimpleConverter()
simple.show()

sys.exit(app.exec_())
