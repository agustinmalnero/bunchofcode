# -*- coding: latin-1 -*-

class Post:

    def __init__(self, t, i, c):
        self._title = t
        self._info = i
        self._content = c

    def _setTitle(self, t):
        self._title = t
    def _getTitle(self):
        return self._title
    title = property(_getTitle, _setTitle)

    def _setInfo(self, i):
        self._info = i
    def _getInfo(self):
        return self._info
    info = property(_getInfo, _setInfo)

    def _setContent(self, c):
        self._content = c
    def _getContent(self):
        return self._content
    content = property(_getContent, _setContent)
