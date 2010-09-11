package tsbtp1.util;

import java.lang.reflect.Field;
import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.util.Vector;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;
import tsbtp1.model.Viaje;

public class Funciones {

    public static void loadTable(JTable tabla, SimpleList lista){
        DefaultTableModel model;
        Vector<String> columns = new Vector<String>();
        Vector data = new Vector();

        boolean readColumns = true;
        Iterator it = lista.iterator();
        while(it.hasNext()){
            Vector row = new Vector();
            Object obj = it.next();

            Field[] fields = obj.getClass().getDeclaredFields();
            for(Field f : fields){
                String columnName = String.valueOf(f.getName().charAt(0)).toUpperCase() +
                        f.getName().substring(1);
                String getterName = "get" + columnName;
                Object value;
                try{
                    Method getter = obj.getClass().getDeclaredMethod(getterName);
                    value = getter.invoke(obj, new Object[0]);
                }catch(NoSuchMethodException e){
                    continue;
                }catch(IllegalAccessException ex){
                    continue;
                }catch(InvocationTargetException exc){
                    continue;
                }
                if(readColumns){
                    columns.add(columnName);
                }
                row.add(value);
            }
            readColumns = false;
            data.add(row);
        }

        model = new DefaultTableModel(data, columns);
        tabla.setModel(model);
    }

    public static void revenue(JTable table, SimpleList<Viaje> viajes){
        DefaultTableModel model;
        Object[] columns = new Object[]{"Detalle", "Cantidad"};
        Object[][] data = new Object[2][2];

        Iterator it = viajes.iterator();
        double amount = 0;
        int cant = 0;
        while(it.hasNext()){
            Object obj = it.next();
            amount += ((Viaje)obj).getPlan().getCuota();
            cant++;
        }

        Object[] row1 = new Object[]{"Cantidad de Viajes:", cant};
        Object[] row2 = new Object[]{"Ingresos obtenidos:", amount};
        data[0] = row1;
        data[1] = row2;

        model = new DefaultTableModel(data, columns);
        table.setModel(model);
    }

}
