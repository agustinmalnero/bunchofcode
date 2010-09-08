package tsbtp1.model;

/**
 *
 * @author Diego Sarmentero
 */
public class Ciudad implements Comparable<Ciudad>{

    private String nombre;

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getNombre() {
        return nombre;
    }

    public String toString(){
        return this.nombre;
    }

    public int compareTo(Ciudad c){
        if(c.getNombre().equalsIgnoreCase(this.nombre)){
            return 0;
        }
        return 1;
    }

}
