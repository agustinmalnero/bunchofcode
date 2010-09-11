package tsbtp1.panels;

import javax.swing.JOptionPane;
import tsbtp1.model.Pasajero;
import tsbtp1.model.Plan;
import tsbtp1.model.Viaje;
import tsbtp1.util.Iterator;
import tsbtp1.util.SimpleList;

public class ViajePanel extends javax.swing.JPanel implements IPanel{

    private SimpleList list;
    private SimpleList plan;
    private SimpleList pasajero;

    public ViajePanel(SimpleList l, SimpleList<Plan> plan,
            SimpleList<Pasajero> pasajero) {
        initComponents();
        this.list = l;
        this.plan = plan;
        this.pasajero = pasajero;

        Iterator i = this.plan.iterator();
        while(i.hasNext()){
            this.comboPlan.addItem(i.next());
        }
        i = this.pasajero.iterator();
        while(i.hasNext()){
            this.comboPasajero.addItem(i.next());
        }
    }

    public void guardar(){
        if(this.validateData()){
            Viaje v = new Viaje();
            v.setPlan((Plan)this.comboPlan.getItemAt(this.comboPlan.getSelectedIndex()));
            v.setPasajero((Pasajero)this.comboPasajero.getItemAt(this.comboPasajero.getSelectedIndex()));
            this.list.add(v);
            this.clear();
        }else{
            JOptionPane.showMessageDialog(this, "Complete la información necesaria.",
                    "Viaje No Valido", JOptionPane.ERROR_MESSAGE);
        }
    }

    public void eliminar(){
        Viaje v = new Viaje();
        v.setPlan((Plan)this.comboPlan.getItemAt(this.comboPlan.getSelectedIndex()));
        v.setPasajero((Pasajero)this.comboPasajero.getItemAt(this.comboPasajero.getSelectedIndex()));
        this.list.remove(v);
        this.clear();
    }

    public void clear(){
        this.comboPasajero.setSelectedIndex(0);
        this.comboPlan.setSelectedIndex(0);
    }

    public boolean validateData(){
        if(this.comboPasajero.getSelectedItem() != null &&
                this.comboPlan.getSelectedItem() != null){
            return true;
        }
        return false;
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        comboPlan = new javax.swing.JComboBox();
        comboPasajero = new javax.swing.JComboBox();

        jLabel1.setText("Plan:");

        jLabel2.setText("Pasajero:");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel2)
                    .addComponent(jLabel1))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(comboPasajero, 0, 305, Short.MAX_VALUE)
                    .addComponent(comboPlan, 0, 305, Short.MAX_VALUE))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(comboPlan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(comboPasajero, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JComboBox comboPasajero;
    private javax.swing.JComboBox comboPlan;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    // End of variables declaration//GEN-END:variables

}
