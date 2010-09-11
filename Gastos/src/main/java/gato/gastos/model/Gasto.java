package gato.gastos.model;

import cat.quickdb.annotation.*;
import java.sql.Date;

@Table
public class Gasto {

    @Column(type=Properties.TYPES.PRIMARYKEY)
    @ColumnDefinition(type=Definition.DATATYPE.INT, length=11,
    autoIncrement=true, primary=true)
    private int id;
    @Column
    @ColumnDefinition(type=Definition.DATATYPE.DATETIME)
    private Date fecha;
    @Column
    @ColumnDefinition
    private String descripcion;
    @Column
    @ColumnDefinition(type=Definition.DATATYPE.DOUBLE)
    private double monto;
    @Column(type=Properties.TYPES.FOREIGNKEY)
    @ColumnDefinition(type=Definition.DATATYPE.INTEGER)
    private TipoGasto tipo;
    @Column(type=Properties.TYPES.SQL)
    private String sql;

    public Gasto(){
        this.fecha = new Date(new java.util.Date().getTime());
        this.descripcion = "";
        this.tipo = new TipoGasto();
        this.sql = "";
    }

    public Gasto(java.util.Date fecha, String descripcion, 
            double monto, TipoGasto tipo){
        this.fecha = new Date(fecha.getTime());
        this.descripcion = descripcion;
        this.monto = monto;
        this.tipo = tipo;
    }

    /**
     * @return the id
     */
    public int getId() {
        return id;
    }

    /**
     * @param id the id to set
     */
    public void setId(int id) {
        this.id = id;
    }

    /**
     * @return the fecha
     */
    public Date getFecha() {
        return fecha;
    }

    /**
     * @param fecha the fecha to set
     */
    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    /**
     * @return the descripcion
     */
    public String getDescripcion() {
        return descripcion;
    }

    /**
     * @param descripcion the descripcion to set
     */
    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    /**
     * @return the monto
     */
    public double getMonto() {
        return monto;
    }

    /**
     * @param monto the monto to set
     */
    public void setMonto(double monto) {
        this.monto = monto;
    }

    /**
     * @return the tipo
     */
    public TipoGasto getTipo() {
        return tipo;
    }

    /**
     * @param tipo the tipo to set
     */
    public void setTipo(TipoGasto tipo) {
        this.tipo = tipo;
    }

    /**
     * @return the sql
     */
    public String getSql() {
        return sql;
    }

    /**
     * @param sql the sql to set
     */
    public void setSql(String sql) {
        this.sql = sql;
    }

}
