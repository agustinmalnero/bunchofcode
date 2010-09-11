package tsbtp1.model;

public class Pasajero implements Comparable<Pasajero>{

    private long dni;
    private String apellido;
    private String nombre;

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public void setDni(String dni) {
        this.dni = Long.parseLong(dni);
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public String getDni() {
        return String.valueOf(dni);
    }


    public String getNombre() {
        return nombre;
    }

    public int compareTo(Pasajero p){
        return (int)(this.dni - p.dni);
    }

    public String toString(){
        return this.dni + " - " + this.apellido + ", " + this.nombre;
    }

}
