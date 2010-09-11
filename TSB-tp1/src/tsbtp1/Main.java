package tsbtp1;
import tsbtp1.util.*;

/**
 *
 * @author gato
 */
public class Main {

    public static void main(String[] args) {
        SimpleList<Integer> l = new SimpleList<Integer>();
        l.add(1);
        System.out.println("agregado 1");
        l.add(4);
        System.out.println("agregado 4");
        l.add(11);
        System.out.println("agregado 11");
        l.add(7);
        System.out.println("agregado 7");
        Iterator<Integer> it = l.iterator();
        while (it.hasNext())
            System.out.println(it.next());
        /*while (it.hasNext())
            System.out.println(it.next());
        if (l.remove(3))
            System.out.println("removido 3");
        else System.out.println("no removido 3");
        if (l.remove(3))
            System.out.println("removido 3");
        else System.out.println("no removido 3");
        while (it.hasNext())
            System.out.println(it.next());
        AgenciaFrame agencia = new AgenciaFrame();
        agencia.setVisible(true);*/
        System.out.println("Ordenar...");
        Comparable[] array = l.ordenar();
        System.out.println("Finalizó Ordenar.");
        for(Comparable c : array){
            System.out.println(c);
        }
    }

}
