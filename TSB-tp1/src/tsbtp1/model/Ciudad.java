package tsbtp1.model;

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
        return this.nombre.compareTo(c.getNombre());
    }

}
