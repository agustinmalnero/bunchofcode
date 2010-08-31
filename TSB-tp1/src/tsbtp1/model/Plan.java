package tsbtp1.model;

/**
 *
 * @author Diego Sarmentero
 */
public class Plan {

    private int id;
    private double cuota;
    private Ciudad destino;

    public void setCuota(double cuota) {
        this.cuota = cuota;
    }

    public void setDestino(Ciudad destino) {
        this.destino = destino;
    }

    public void setId(int id) {
        this.id = id;
    }

    public double getCuota() {
        return cuota;
    }

    public Ciudad getDestino() {
        return destino;
    }

    public int getId() {
        return id;
    }

}
