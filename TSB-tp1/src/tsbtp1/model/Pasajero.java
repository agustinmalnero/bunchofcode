package tsbtp1.model;

public class Pasajero implements Comparable<Pasajero>{

    private String dni;
    private String apellido;
    private String nombre;

    public Pasajero() {
    }

    public Pasajero(String dni, String apellido, String nombre) {
        this.dni = dni;
        this.apellido = apellido;
        this.nombre = nombre;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public void setDni(String dni) {
        this.dni = dni;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public String getDni() {
        return dni;
    }


    public String getNombre() {
        return nombre;
    }

    public int compareTo(Pasajero p){
        return (int)(Integer.parseInt(this.dni) -
                Integer.parseInt(p.getDni()));
    }

    public String toString(){
        return this.dni + " - " + this.apellido + ", " + this.nombre;
    }

}
