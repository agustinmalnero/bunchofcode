#include "browser.h"

Browser::Browser(QWidget *parent) :
    QWidget(parent)
{
    this->setWindowTitle("Simple Browser");

    QVBoxLayout *v_box = new QVBoxLayout();

    QHBoxLayout *h_box = new QHBoxLayout();
    QPushButton *previous = new QPushButton(this->style()->standardIcon(QStyle::SP_ArrowLeft), "");
    QPushButton *next = new QPushButton(this->style()->standardIcon(QStyle::SP_ArrowRight), "");
    QPushButton *reload = new QPushButton(this->style()->standardIcon(QStyle::SP_BrowserReload), "");
    QPushButton *stop = new QPushButton(this->style()->standardIcon(QStyle::SP_BrowserStop), "");
    this->url = new QLineEdit;
    QPushButton *okUrl = new QPushButton(this->style()->standardIcon(QStyle::SP_DialogOkButton), "");
    okUrl->setFlat(true);
    h_box->addWidget(previous);
    h_box->addWidget(next);
    h_box->addWidget(reload);
    h_box->addWidget(stop);
    h_box->addWidget(url);
    h_box->addWidget(okUrl);

    this->web = new QWebView(this);
    this->web->load(QUrl("http://google.com"));

    this->status = new QStatusBar;
    this->progressBar = new QProgressBar;
    QLabel *lbl = new QLabel("Loading...");
    this->status->addWidget(lbl);
    this->status->addWidget(this->progressBar);

    v_box->addLayout(h_box);
    v_box->addWidget(this->web);
    v_box->addWidget(this->status);
    this->setLayout(v_box);

    QShortcut *shortcut = new QShortcut(QKeySequence(Qt::ALT + Qt::Key_D), this->url);

    this->connect(previous, SIGNAL(clicked()), this->web, SLOT(back()));
    this->connect(next, SIGNAL(clicked()), this->web, SLOT(forward()));
    this->connect(reload, SIGNAL(clicked()), this->web, SLOT(reload()));
    this->connect(stop, SIGNAL(clicked()), this->web, SLOT(stop()));
    this->connect(this->url, SIGNAL(returnPressed()), this, SLOT(doSearch()));
    this->connect(okUrl, SIGNAL(clicked()), this, SLOT(doSearch()));
    this->connect(this->web, SIGNAL(loadProgress(int)), this, SLOT(progress(int)));
    this->connect(this->web, SIGNAL(loadFinished(bool)), this, SLOT(loadComplete(bool)));
    this->connect(this->web, SIGNAL(loadStarted()), this->status, SLOT(show()));
    this->connect(shortcut, SIGNAL(activated()), this->url, SLOT(setFocus()));
}

void Browser::openUrl(QString text)
{
    //this->setWindowTitle(text);
    this->web->setFocus();
    this->web->load(QUrl(text));
}

void Browser::progress(int val)
{
    this->progressBar->setValue(val);
}

void Browser::doSearch()
{
    QString link = this->url->text();
    QRegExp reg("(.+)\\.(.+)");
    QRegExp regHttp("^http://");
    if(reg.exactMatch(link) && !regHttp.exactMatch(link)){
        link = "http://" + this->url->text();
    }else if(!reg.exactMatch(link)){
        link = "http://google.com/search?q=" + link.replace(" ", "+");
    }
    this->openUrl(link);
}

void Browser::loadComplete(bool val)
{
    this->url->setText(this->web->url().toString());
    this->status->hide();
}
