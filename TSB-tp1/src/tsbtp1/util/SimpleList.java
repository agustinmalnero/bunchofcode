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

    public SimpleList(){
        front = null;
    }

    public void add(T t){
        boolean exists = false;
        Iterator<T> it = iterator();
        Comparable value = null;
        while (it.hasNext()){
            value = it.next();
            if (value.compareTo(t) == 0)
                exists = true;
        }
        if (!exists){
            Node p = new Node(t);
            p.next=front;
            front = p;
        }
    }

    public boolean remove(T t){
        if (front != null){
            Node previous = null;
            Node actual = front;
            while (actual != null && actual.value.compareTo(t) != 0){
                previous = actual;
                actual = actual.next;
            }
            if (actual != null){
                previous.next = actual.next;
                return true;
            }
        }
        return false;
    }

    public Iterator<T> iterator(){
        return new SimpleListIterator<T>();
    }

    class Node {

        private T value;
        private Node next;

        public Node(T value){
            this.value = value;
        }
     }


    class SimpleListIterator<T extends Comparable> implements Iterator<T>{

        private Node actual;

        public SimpleListIterator(){
            actual = front;
        }



        public boolean hasNext(){
            if (actual!=null)
                return true;
            actual = front;
            return false;
        }

        public Comparable next() {
            T res = (T) actual.value;
            actual = actual.next;
            return res;
        }
    }
}
