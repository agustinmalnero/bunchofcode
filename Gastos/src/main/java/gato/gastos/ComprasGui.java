package gato.gastos;

import gato.gastos.model.Compras;
import java.util.Vector;
import cat.quickdb.db.AdminBase;
import java.util.ArrayList;

public class ComprasGui extends javax.swing.JDialog {

    private Vector<Compras> data;
    private AdminBase admin;

    public ComprasGui(java.awt.Frame parent, boolean modal, AdminBase admin) {
        super(parent, modal);
        initComponents();
        data = new Vector();
        this.admin = admin;

        Compras compras = new Compras();
        ArrayList datos = admin.obtainAll(compras);
        this.data.addAll(datos);

        this.jList.setListData(data);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        jList = new javax.swing.JList();
        jBtnComprados = new javax.swing.JButton();
        jSeparator1 = new javax.swing.JSeparator();
        jTxtCompra = new javax.swing.JTextField();
        jBtnAgregar = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);

        jLabel1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel1.setText("Compras a Realizar:");

        jScrollPane1.setViewportView(jList);

        jBtnComprados.setText("Comprados");
        jBtnComprados.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jBtnCompradosActionPerformed(evt);
            }
        });

        jTxtCompra.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                jTxtCompraKeyPressed(evt);
            }
        });

        jBtnAgregar.setText("Agregar");
        jBtnAgregar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jBtnAgregarActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 352, Short.MAX_VALUE)
                    .addComponent(jLabel1, javax.swing.GroupLayout.DEFAULT_SIZE, 352, Short.MAX_VALUE)
                    .addComponent(jBtnComprados)
                    .addComponent(jSeparator1, javax.swing.GroupLayout.DEFAULT_SIZE, 352, Short.MAX_VALUE)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addComponent(jTxtCompra, javax.swing.GroupLayout.DEFAULT_SIZE, 285, Short.MAX_VALUE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jBtnAgregar)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 235, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jBtnComprados)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jSeparator1, javax.swing.GroupLayout.PREFERRED_SIZE, 10, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jTxtCompra, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jBtnAgregar))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jBtnAgregarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jBtnAgregarActionPerformed
        Compras compra = new Compras(this.jTxtCompra.getText());
        this.jTxtCompra.setText("");
        this.jTxtCompra.requestFocus();
        data.add(compra);
        admin.save(compra);

        this.jList.setListData(data);
    }//GEN-LAST:event_jBtnAgregarActionPerformed

    private void jTxtCompraKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_jTxtCompraKeyPressed
        if(evt.getKeyCode() == 10){
            this.jBtnAgregarActionPerformed(null);
        }
    }//GEN-LAST:event_jTxtCompraKeyPressed

    private void jBtnCompradosActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jBtnCompradosActionPerformed
        int indices[] = this.jList.getSelectedIndices();

        for(int i = indices.length-1; i > -1; i--){
            Compras compra = this.data.get(indices[i]);
            compra.setSql("id = " + compra.getId());
            admin.delete(compra);
            data.removeElementAt(indices[i]);
        }

        this.jList.setListData(data);
    }//GEN-LAST:event_jBtnCompradosActionPerformed

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jBtnAgregar;
    private javax.swing.JButton jBtnComprados;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JList jList;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JSeparator jSeparator1;
    private javax.swing.JTextField jTxtCompra;
    // End of variables declaration//GEN-END:variables

}
