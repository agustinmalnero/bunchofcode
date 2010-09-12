#ifndef BROWSER_H
#define BROWSER_H

#include <QtGui>
#include <QtCore>
#include <QtWebKit/QWebView>

class Browser : public QWidget
{

Q_OBJECT

public:
    Browser(QWidget *parent = 0);

public slots:
    void doSearch();
    void progress(int val);
    void loadComplete(bool val);

private:
    void openUrl(QString text);
    QLineEdit *url;
    QWebView *web;
    QStatusBar *status;
    QProgressBar *progressBar;

};

#endif // BROWSER_H
