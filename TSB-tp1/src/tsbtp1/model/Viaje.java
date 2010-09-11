package tsbtp1.model;

/**
 *
 * @author Diego Sarmentero
 */
public class Viaje implements Comparable<Viaje>{

    private Pasajero pasajero;
    private Plan plan;

    public void setPasajero(Pasajero pasajero) {
        this.pasajero = pasajero;
    }

    public void setPlan(Plan plan) {
        this.plan = plan;
    }

    public Pasajero getPasajero() {
        return pasajero;
    }

    public Plan getPlan() {
        return plan;
    }

    public int compareTo(Viaje v){
        return this.plan.getDestino().getNombre().compareTo(v.getPlan().getDestino().getNombre());
    }

}
