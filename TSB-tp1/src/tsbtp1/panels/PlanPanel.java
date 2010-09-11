package tsbtp1.panels;

import javax.swing.JOptionPane;
import javax.swing.text.MaskFormatter;
import tsbtp1.model.Ciudad;
import tsbtp1.model.Plan;
import tsbtp1.util.Iterator;
import tsbtp1.util.SimpleList;

public class PlanPanel extends javax.swing.JPanel implements IPanel {

    private SimpleList list;

    public PlanPanel(SimpleList l, SimpleList<Ciudad> ciudades) {
        initComponents();
        this.list = l;

        try {
            MaskFormatter mask = new MaskFormatter("####.##");
            mask.install(txtFormatCuota);
        } catch (Exception e) {
            e.printStackTrace();
        }

        Iterator i = ciudades.iterator();
        while(i.hasNext()){
            this.comboDestino.addItem(i.next());
        }
    }

    public void guardar(){
        if(validateData()){
            Plan p = new Plan();
            String monto = this.txtFormatCuota.getText().replaceAll(" ", "");
            p.setCuota(Double.parseDouble(monto));
            p.setDestino((Ciudad)this.comboDestino.getItemAt(this.comboDestino.getSelectedIndex()));
            this.list.add(p);
            this.clear();
        }else{
            JOptionPane.showMessageDialog(this, "Debe ingresar un destino y un monto.",
                    "Plan No Valido", JOptionPane.ERROR_MESSAGE);
        }
    }

    public void eliminar(){
        Plan p = new Plan();
        String monto = this.txtFormatCuota.getText().replaceAll(" ", "");
        p.setCuota(Double.parseDouble(monto));
        p.setDestino((Ciudad)this.comboDestino.getItemAt(this.comboDestino.getSelectedIndex()));
        this.list.remove(p);
        this.clear();
    }

    public void clear(){
        this.txtFormatCuota.setText("");
        this.comboDestino.setSelectedIndex(0);
    }

    public boolean validateData(){
        if(!this.txtFormatCuota.getText().replaceAll(" ", "").equalsIgnoreCase(".") &&
                this.comboDestino.getSelectedItem() != null){
            return true;
        }
        return false;
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        comboDestino = new javax.swing.JComboBox();
        txtFormatCuota = new javax.swing.JFormattedTextField();

        setPreferredSize(new java.awt.Dimension(400, 117));

        jLabel1.setText("Destino:");

        jLabel2.setText("Cuota:");

        txtFormatCuota.setForeground(new java.awt.Color(24, 23, 180));
        txtFormatCuota.setHorizontalAlignment(javax.swing.JTextField.RIGHT);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel1)
                    .addComponent(jLabel2))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(txtFormatCuota, javax.swing.GroupLayout.DEFAULT_SIZE, 305, Short.MAX_VALUE)
                    .addComponent(comboDestino, 0, 305, Short.MAX_VALUE))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(comboDestino, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(txtFormatCuota, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
    }// </editor-fold>//GEN-END:initComponents
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JComboBox comboDestino;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JFormattedTextField txtFormatCuota;
    // End of variables declaration//GEN-END:variables
}
