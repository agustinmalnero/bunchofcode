package tsbtp1.model;

/**
 *
 * @author Diego Sarmentero
 */
public class Pasajero {

    private int id;
    private String dni;
    private String apellido;
    private String nombre;

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public void setDni(String dni) {
        this.dni = dni;
    }

    public void setId(int id) {
        this.id = id;
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

    public int getId() {
        return id;
    }

    public String getNombre() {
        return nombre;
    }

}
