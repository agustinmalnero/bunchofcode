package tsbtp1.model;

/**
 *
 * @author Diego Sarmentero
 */
public class Paciente {

    private int id;
    private Pasajero pasajero;
    private Plan plan;

    public void setId(int id) {
        this.id = id;
    }

    public void setPasajero(Pasajero pasajero) {
        this.pasajero = pasajero;
    }

    public void setPlan(Plan plan) {
        this.plan = plan;
    }

    public int getId() {
        return id;
    }

    public Pasajero getPasajero() {
        return pasajero;
    }

    public Plan getPlan() {
        return plan;
    }

}
