package tsbtp1;
import tsbtp1.model.Pasajero;
import tsbtp1.util.*;

/**
 *
 * @author gato
 */
public class Main {

    public static void main(String[] args) {
        SimpleList<Pasajero> l = new SimpleList<Pasajero>();
        l.add(new Pasajero("31756403", "Sarmentero", "Diego"));
        l.add(new Pasajero("33544123", "Otro", "Mas"));
        l.add(new Pasajero("11111222", "addfdsf", "dsfdsd"));
        l.add(new Pasajero("11222111", "Apellido", "Nombre"));
        Iterator<Pasajero> it = l.iterator();
        while (it.hasNext())
            System.out.println(it.next());
        /*AgenciaFrame agencia = new AgenciaFrame();
        agencia.setVisible(true);*/
        System.out.println("Ordenar...");
        Comparable[] array = l.ordenar();
        System.out.println("Finalizó Ordenar.");
        for(Comparable c : array){
            System.out.println(c);
        }
    }

}
