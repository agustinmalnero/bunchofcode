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
        if(this.plan.compareTo(v.getPlan()) == 0 &&
                this.pasajero.compareTo(v.getPasajero()) == 0){
            return 0;
        }
        return -1;
    }

}
