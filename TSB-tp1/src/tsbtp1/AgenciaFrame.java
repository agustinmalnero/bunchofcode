package tsbtp1;

import tsbtp1.panels.IPanel;
import java.awt.BorderLayout;
import javax.swing.JOptionPane;
import tsbtp1.model.Ciudad;
import tsbtp1.model.Pasajero;
import tsbtp1.model.Plan;
import tsbtp1.model.Viaje;
import tsbtp1.panels.CiudadPanel;
import tsbtp1.panels.PasajeroPanel;
import tsbtp1.panels.PlanPanel;
import tsbtp1.panels.ViajePanel;
import tsbtp1.util.Funciones;
import tsbtp1.util.SimpleList;

public class AgenciaFrame extends javax.swing.JFrame {

    private IPanel iPanel;
    private enum Mode { PASAJERO, PLAN, VIAJE, CIUDAD, INGRESOS };

    private SimpleList<Ciudad> ciudadList;
    private SimpleList<Pasajero> pasajeroList;
    private SimpleList<Viaje> viajeList;
    private SimpleList<Plan> planList;

    public AgenciaFrame() {
        initComponents();
        this.panelCargas.setLayout(new BorderLayout());
        this.ciudadList = new SimpleList<Ciudad>();
        this.pasajeroList = new SimpleList<Pasajero>();
        this.viajeList = new SimpleList<Viaje>();
        this.planList = new SimpleList<Plan>();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jTabbedPane1 = new javax.swing.JTabbedPane();
        jPanel1 = new javax.swing.JPanel();
        panelCargas = new javax.swing.JPanel();
        toolCargas = new javax.swing.JToolBar();
        btnGuardar = new javax.swing.JButton();
        btnCancelar = new javax.swing.JButton();
        jSeparator1 = new javax.swing.JToolBar.Separator();
        jSeparator2 = new javax.swing.JSeparator();
        btnPasajero = new javax.swing.JToggleButton();
        btnPlan = new javax.swing.JToggleButton();
        btnViaje = new javax.swing.JToggleButton();
        btnCiudad = new javax.swing.JToggleButton();
        jPanel2 = new javax.swing.JPanel();
        toolConsultas = new javax.swing.JToolBar();
        btnOrdenar = new javax.swing.JButton();
        jSeparator4 = new javax.swing.JToolBar.Separator();
        btnBuscar = new javax.swing.JButton();
        txtBuscar = new javax.swing.JTextField();
        btnPasajeroConsulta = new javax.swing.JToggleButton();
        btnPlanConsulta = new javax.swing.JToggleButton();
        btnViajeConsulta = new javax.swing.JToggleButton();
        btnCiudadConsulta = new javax.swing.JToggleButton();
        jSeparator3 = new javax.swing.JSeparator();
        panelCargas1 = new javax.swing.JPanel();
        jScrollPane1 = new javax.swing.JScrollPane();
        jTablaConsulta = new javax.swing.JTable();
        btnIngresos = new javax.swing.JToggleButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Agencia de Viajes");

        javax.swing.GroupLayout panelCargasLayout = new javax.swing.GroupLayout(panelCargas);
        panelCargas.setLayout(panelCargasLayout);
        panelCargasLayout.setHorizontalGroup(
            panelCargasLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 539, Short.MAX_VALUE)
        );
        panelCargasLayout.setVerticalGroup(
            panelCargasLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 310, Short.MAX_VALUE)
        );

        toolCargas.setFloatable(false);
        toolCargas.setRollover(true);

        btnGuardar.setText("Guardar");
        btnGuardar.setFocusable(false);
        btnGuardar.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        btnGuardar.setVerticalTextPosition(javax.swing.SwingConstants.BOTTOM);
        btnGuardar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnGuardarActionPerformed(evt);
            }
        });
        toolCargas.add(btnGuardar);

        btnCancelar.setText("Cancelar");
        btnCancelar.setFocusable(false);
        btnCancelar.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        btnCancelar.setVerticalTextPosition(javax.swing.SwingConstants.BOTTOM);
        btnCancelar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCancelarActionPerformed(evt);
            }
        });
        toolCargas.add(btnCancelar);
        toolCargas.add(jSeparator1);

        jSeparator2.setOrientation(javax.swing.SwingConstants.VERTICAL);

        btnPasajero.setText("Pasajero");
        btnPasajero.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnPasajeroActionPerformed(evt);
            }
        });

        btnPlan.setText("Plan");
        btnPlan.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnPlanActionPerformed(evt);
            }
        });

        btnViaje.setText("Viaje");
        btnViaje.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnViajeActionPerformed(evt);
            }
        });

        btnCiudad.setText("Ciudad");
        btnCiudad.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCiudadActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(toolCargas, javax.swing.GroupLayout.DEFAULT_SIZE, 636, Short.MAX_VALUE)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(btnCiudad, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(btnViaje, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(btnPlan, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(btnPasajero, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jSeparator2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(panelCargas, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(panelCargas, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jSeparator2, javax.swing.GroupLayout.DEFAULT_SIZE, 310, Short.MAX_VALUE)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addComponent(btnPasajero)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnPlan)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnViaje)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnCiudad)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(toolCargas, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE))
        );

        jTabbedPane1.addTab("Cargas", jPanel1);

        toolConsultas.setFloatable(false);
        toolConsultas.setRollover(true);

        btnOrdenar.setText("Ordernar Tabla");
        btnOrdenar.setEnabled(false);
        btnOrdenar.setFocusable(false);
        btnOrdenar.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        btnOrdenar.setVerticalTextPosition(javax.swing.SwingConstants.BOTTOM);
        btnOrdenar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnOrdenarActionPerformed(evt);
            }
        });
        toolConsultas.add(btnOrdenar);
        toolConsultas.add(jSeparator4);

        btnBuscar.setText("Buscar por DNI:");
        btnBuscar.setFocusable(false);
        btnBuscar.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        btnBuscar.setVerticalTextPosition(javax.swing.SwingConstants.BOTTOM);
        btnBuscar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnBuscarActionPerformed(evt);
            }
        });
        toolConsultas.add(btnBuscar);
        toolConsultas.add(txtBuscar);

        btnPasajeroConsulta.setText("Pasajero");
        btnPasajeroConsulta.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnPasajeroConsultaActionPerformed(evt);
            }
        });

        btnPlanConsulta.setText("Plan");
        btnPlanConsulta.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnPlanConsultaActionPerformed(evt);
            }
        });

        btnViajeConsulta.setText("Viaje");
        btnViajeConsulta.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnViajeConsultaActionPerformed(evt);
            }
        });

        btnCiudadConsulta.setText("Ciudad");
        btnCiudadConsulta.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCiudadConsultaActionPerformed(evt);
            }
        });

        jSeparator3.setOrientation(javax.swing.SwingConstants.VERTICAL);

        jTablaConsulta.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {

            }
        ));
        jScrollPane1.setViewportView(jTablaConsulta);

        javax.swing.GroupLayout panelCargas1Layout = new javax.swing.GroupLayout(panelCargas1);
        panelCargas1.setLayout(panelCargas1Layout);
        panelCargas1Layout.setHorizontalGroup(
            panelCargas1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 529, Short.MAX_VALUE)
        );
        panelCargas1Layout.setVerticalGroup(
            panelCargas1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 310, Short.MAX_VALUE)
        );

        btnIngresos.setText("Ingresos");
        btnIngresos.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnIngresosActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(toolConsultas, javax.swing.GroupLayout.DEFAULT_SIZE, 636, Short.MAX_VALUE)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(btnPlanConsulta, javax.swing.GroupLayout.DEFAULT_SIZE, 76, Short.MAX_VALUE)
                    .addComponent(btnViajeConsulta, javax.swing.GroupLayout.DEFAULT_SIZE, 76, Short.MAX_VALUE)
                    .addComponent(btnCiudadConsulta, javax.swing.GroupLayout.DEFAULT_SIZE, 76, Short.MAX_VALUE)
                    .addComponent(btnPasajeroConsulta, javax.swing.GroupLayout.DEFAULT_SIZE, 76, Short.MAX_VALUE)
                    .addComponent(btnIngresos, javax.swing.GroupLayout.DEFAULT_SIZE, 76, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jSeparator3, javax.swing.GroupLayout.PREFERRED_SIZE, 7, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(panelCargas1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addComponent(btnPasajeroConsulta)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnPlanConsulta)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnViajeConsulta)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnCiudadConsulta)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnIngresos))
                    .addComponent(jSeparator3, javax.swing.GroupLayout.DEFAULT_SIZE, 310, Short.MAX_VALUE)
                    .addComponent(panelCargas1, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(toolConsultas, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE))
        );

        jTabbedPane1.addTab("Consultas", jPanel2);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jTabbedPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 648, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jTabbedPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 396, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnPasajeroActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnPasajeroActionPerformed
        this.selectedButtonCargas(Mode.PASAJERO);
        PasajeroPanel pasajero = new PasajeroPanel(this.pasajeroList);
        iPanel = pasajero;
        this.panelCargas.add(pasajero);
        this.panelCargas.updateUI();
    }//GEN-LAST:event_btnPasajeroActionPerformed

    private void btnPlanActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnPlanActionPerformed
        this.selectedButtonCargas(Mode.PLAN);
        PlanPanel plan = new PlanPanel(this.planList, this.ciudadList);
        iPanel = plan;
        this.panelCargas.add(plan);
        this.panelCargas.updateUI();
    }//GEN-LAST:event_btnPlanActionPerformed

    private void btnViajeActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnViajeActionPerformed
        this.selectedButtonCargas(Mode.VIAJE);
        ViajePanel viaje = new ViajePanel(this.viajeList, this.planList, this.pasajeroList);
        iPanel = viaje;
        this.panelCargas.add(viaje);
        this.panelCargas.updateUI();
    }//GEN-LAST:event_btnViajeActionPerformed

    private void btnCiudadActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCiudadActionPerformed
        this.selectedButtonCargas(Mode.CIUDAD);
        CiudadPanel ciudad = new CiudadPanel(this.ciudadList);
        iPanel = ciudad;
        this.panelCargas.add(ciudad);
        this.panelCargas.updateUI();
    }//GEN-LAST:event_btnCiudadActionPerformed

    private void btnGuardarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnGuardarActionPerformed
        if(iPanel != null){
            this.iPanel.guardar();
        }
    }//GEN-LAST:event_btnGuardarActionPerformed

    private void btnCancelarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCancelarActionPerformed
        this.panelCargas.removeAll();
        this.panelCargas.updateUI();
        this.iPanel = null;
    }//GEN-LAST:event_btnCancelarActionPerformed

    private void btnPasajeroConsultaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnPasajeroConsultaActionPerformed
        this.selectedButtonConsultas(Mode.PASAJERO);
        Funciones.loadTable(jTablaConsulta, pasajeroList);
    }//GEN-LAST:event_btnPasajeroConsultaActionPerformed

    private void btnPlanConsultaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnPlanConsultaActionPerformed
        this.selectedButtonConsultas(Mode.PLAN);
        Funciones.loadTable(jTablaConsulta, planList);
    }//GEN-LAST:event_btnPlanConsultaActionPerformed

    private void btnViajeConsultaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnViajeConsultaActionPerformed
        this.selectedButtonConsultas(Mode.VIAJE);
        Funciones.loadTable(jTablaConsulta, viajeList);
    }//GEN-LAST:event_btnViajeConsultaActionPerformed

    private void btnCiudadConsultaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCiudadConsultaActionPerformed
        this.selectedButtonConsultas(Mode.CIUDAD);
        Funciones.loadTable(jTablaConsulta, ciudadList);
    }//GEN-LAST:event_btnCiudadConsultaActionPerformed

    private void btnIngresosActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnIngresosActionPerformed
        this.selectedButtonConsultas(Mode.INGRESOS);
        this.btnOrdenar.setEnabled(false);
        Funciones.revenue(jTablaConsulta, viajeList);
    }//GEN-LAST:event_btnIngresosActionPerformed

    private void btnOrdenarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnOrdenarActionPerformed
        Comparable[] array = null;
        if(this.btnCiudadConsulta.isSelected()){
            array = this.ciudadList.ordenar();
        }else if(this.btnPasajeroConsulta.isSelected()){
            array = this.pasajeroList.ordenar();
        }else if(this.btnPlanConsulta.isSelected()){
            array = this.planList.ordenar();
        }else if(this.btnViajeConsulta.isSelected()){
            array = this.viajeList.ordenar();
        }

        Funciones.loadOrderTable(jTablaConsulta, array);
        this.btnOrdenar.setEnabled(false);
    }//GEN-LAST:event_btnOrdenarActionPerformed

    private void btnBuscarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnBuscarActionPerformed
        Comparable[] array = this.pasajeroList.ordenar();
        Comparable obj = null;
        if(array.length > 0){
            obj = Funciones.findPassenger(this.txtBuscar.getText().trim(),
                    array, 0, array.length-1);
        }

        if(obj != null){
            int option = JOptionPane.showConfirmDialog(this, "Desea ver los viajes del Pasajero:\n" +
                    ((Pasajero)obj).getNombre() + ", " + ((Pasajero)obj).getApellido() +
                    " - " + ((Pasajero)obj).getDni(),
                    "Pasajero Encontrado", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE);

            if(option == JOptionPane.YES_OPTION){
                Object[] objects = Funciones.filter(this.txtBuscar.getText().trim(),
                        this.viajeList.toArray());
                Funciones.loadOrderTable(jTablaConsulta, objects);
            }
        }else{
            JOptionPane.showMessageDialog(this, "No se encontro un pasajero con ese DNI",
                    "Pasajero No Encontrado", JOptionPane.INFORMATION_MESSAGE);
        }

        this.selectedButtonConsultas(Mode.INGRESOS);
        this.btnIngresos.setSelected(false);
        this.btnOrdenar.setEnabled(false);
    }//GEN-LAST:event_btnBuscarActionPerformed

    private void selectedButtonCargas(Mode mode){
        this.panelCargas.removeAll();
        this.btnPasajero.setSelected(false);
        this.btnViaje.setSelected(false);
        this.btnPlan.setSelected(false);
        this.btnCiudad.setSelected(false);
        switch(mode){
            case PASAJERO:
                this.btnPasajero.setSelected(true);break;
            case CIUDAD:
                this.btnCiudad.setSelected(true);break;
            case VIAJE:
                this.btnViaje.setSelected(true);break;
            case PLAN:
                this.btnPlan.setSelected(true);break;
        }
    }

    private void selectedButtonConsultas(Mode mode){
        this.btnPasajeroConsulta.setSelected(false);
        this.btnViajeConsulta.setSelected(false);
        this.btnPlanConsulta.setSelected(false);
        this.btnCiudadConsulta.setSelected(false);
        this.btnIngresos.setSelected(false);
        switch(mode){
            case PASAJERO:
                this.btnPasajeroConsulta.setSelected(true);break;
            case CIUDAD:
                this.btnCiudadConsulta.setSelected(true);break;
            case VIAJE:
                this.btnViajeConsulta.setSelected(true);break;
            case PLAN:
                this.btnPlanConsulta.setSelected(true);break;
            case INGRESOS:
                this.btnIngresos.setSelected(true);break;
        }

        this.btnOrdenar.setEnabled(true);
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnBuscar;
    private javax.swing.JButton btnCancelar;
    private javax.swing.JToggleButton btnCiudad;
    private javax.swing.JToggleButton btnCiudadConsulta;
    private javax.swing.JButton btnGuardar;
    private javax.swing.JToggleButton btnIngresos;
    private javax.swing.JButton btnOrdenar;
    private javax.swing.JToggleButton btnPasajero;
    private javax.swing.JToggleButton btnPasajeroConsulta;
    private javax.swing.JToggleButton btnPlan;
    private javax.swing.JToggleButton btnPlanConsulta;
    private javax.swing.JToggleButton btnViaje;
    private javax.swing.JToggleButton btnViajeConsulta;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JToolBar.Separator jSeparator1;
    private javax.swing.JSeparator jSeparator2;
    private javax.swing.JSeparator jSeparator3;
    private javax.swing.JToolBar.Separator jSeparator4;
    private javax.swing.JTabbedPane jTabbedPane1;
    private javax.swing.JTable jTablaConsulta;
    private javax.swing.JPanel panelCargas;
    private javax.swing.JPanel panelCargas1;
    private javax.swing.JToolBar toolCargas;
    private javax.swing.JToolBar toolConsultas;
    private javax.swing.JTextField txtBuscar;
    // End of variables declaration//GEN-END:variables

}
