package tsbtp1.model;

public class Pasajero implements Comparable<Pasajero>{

    private String dni;
    private String apellido;
    private String nombre;

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
        if(p.getDni().equalsIgnoreCase(this.dni)){
            return 0;
        }
        return 1;
    }

}
