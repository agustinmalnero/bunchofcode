package tsbtp1.model;

/**
 *
 * @author Diego Sarmentero
 */
public class Plan implements Comparable<Plan>{

    private double cuota;
    private Ciudad destino;

    public void setCuota(double cuota) {
        this.cuota = cuota;
    }

    public void setDestino(Ciudad destino) {
        this.destino = destino;
    }

    public double getCuota() {
        return cuota;
    }

    public Ciudad getDestino() {
        return destino;
    }

    public int compareTo(Plan p){
        if(p.getCuota() == this.cuota &&
                p.getDestino().getNombre().equalsIgnoreCase(this.destino.getNombre())){
            return 0;
        }
        return 1;
    }

    public String toString(){
        return this.destino + " - " + this.cuota;
    }

}
