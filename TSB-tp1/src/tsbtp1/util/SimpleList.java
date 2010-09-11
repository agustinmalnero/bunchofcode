/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package tsbtp1.util;

/**
 *
 * @author tato
 */
public class SimpleList<T extends Comparable> {

    private Node front;
    private int size;

    public SimpleList() {
        front = null;
        size = 0;
    }

    public boolean add(T t) {
        Iterator<T> it = iterator();
        Comparable value = null;
        while (it.hasNext()) {
            value = it.next();
            if (value.compareTo(t) == 0) {
                return false;
            }
        }
        Node p = new Node(t);
        p.next = front;
        front = p;
        size++;
        return true;
    }

    public boolean remove(T t) {
        if (front != null) {
            Node previous = null;
            Node actual = front;
            while (actual != null && actual.value.compareTo(t) != 0) {
                previous = actual;
                actual = actual.next;
            }
            if (actual != null) {
                previous.next = actual.next;
                size--;
                return true;
            }
        }
        return false;
    }
    
    public Iterator<T> iterator() {
        return new SimpleListIterator<T>();
    }

    class Node {

        private T value;
        private Node next;

        public Node(T value) {
            this.value = value;
        }
    }

    class SimpleListIterator<T extends Comparable> implements Iterator<T> {

        private Node actual;

        public SimpleListIterator() {
            actual = front;
        }

        public boolean hasNext() {
            if (actual != null) {
                return true;
            }
            actual = front;
            return false;
        }

        public Comparable next() {
            T res = (T) actual.value;
            actual = actual.next;
            return res;
        }
    }

    public Comparable[] toArray() {
        Comparable[] array = new Comparable[size];
        Iterator it = iterator();
        for (int i = 0; it.hasNext(); i++) {
            array[i] = (T) it.next();
        }
        return array;
    }

    void ordenarQuicksort(Comparable[] array, int first, int last) {
        int f = first, l = last;
        Comparable middle = array[(first + last) / 2];
        Comparable aux;
        do {
            while (array[f].compareTo(middle) < 0) {
                f++;
            }
            while (array[l].compareTo(middle) > 0) {
                l--;
            }
            if (f < l) {
                aux = array[l];
                array[l] = array[f];
                array[f] = aux;
                f++;
                l--;
            }
        } while (f <= l);
        if (first < l) {
            ordenarQuicksort(array, first, l);
        }
        if (last > f) {
            ordenarQuicksort(array, f, last);
        }
    }

    public Comparable[] ordenar() {
        Comparable[] array = toArray();
        ordenarQuicksort(array, 0, size - 1);
        return array;
    }
}
