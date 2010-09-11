package gato.gastos;

import gato.gastos.model.Gasto;
import gato.gastos.model.TipoGasto;
import java.util.ArrayList;
import java.util.Date;
import java.util.Vector;
import javax.swing.UIManager;
import javax.swing.table.DefaultTableModel;
import cat.quickdb.db.AdminBase;
import javax.swing.JOptionPane;
import cat.sistema.commons.tablas.RenderTabla;
import java.text.DecimalFormat;

public class GastosGui extends javax.swing.JFrame {

    private DefaultTableModel defaultTable;
    private DefaultTableModel defaultConsultas;
    private AdminBase admin;
    private JOptionPane pane;
    private Vector titulos;
    private ArrayList<TipoGasto> tipos;
    private ArrayList<Gasto> consultas;
    private boolean update;
    private RenderTabla miRender;
    private Gasto modificar;

    public GastosGui() {
        initComponents();
        admin = new AdminBase(AdminBase.DATABASE.MYSQL, "localhost",
                "3306", "gastos", "root", "");
        this.update = false;

        titulos = new Vector();
        titulos.add("Fecha");
        titulos.add("Descripcion");
        titulos.add("Monto");

        defaultTable = new DefaultTableModel(titulos, 0);
        defaultConsultas = new DefaultTableModel(titulos, 0);
        miRender = new RenderTabla();

        TipoGasto tipo = new TipoGasto();
        tipos = admin.obtainAll(tipo);
        if(tipos.size() > 0){
            for (TipoGasto t : tipos) {
                this.jComboTipo.addItem(t);
            }
        }else{
            tipo.setTipo("Generales");
            admin.save(tipo);
            tipo.setTipo("Diego");
            admin.save(tipo);
            tipo.setTipo("Marcelo");
            admin.save(tipo);
        }

        this.jTableGastos.setModel(defaultTable);
        this.jTableConsultas.setModel(defaultConsultas);
        this.pane = new JOptionPane();

        Date date = new Date();
        this.jComboMes.setSelectedIndex(date.getMonth());
        this.update = true;
        this.actualizar();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        jComboTipo = new javax.swing.JComboBox();
        jScrollPane1 = new javax.swing.JScrollPane();
        jTableGastos = new javax.swing.JTable();
        jBtnAdd = new javax.swing.JButton();
        jBtnRemove = new javax.swing.JButton();
        jBtnGuardar = new javax.swing.JButton();
        jToolBar1 = new javax.swing.JToolBar();
        jBtnAgregar = new javax.swing.JButton();
        jBtnModificar = new javax.swing.JButton();
        jBtnEliminar = new javax.swing.JButton();
        jSeparator3 = new javax.swing.JToolBar.Separator();
        jLabel5 = new javax.swing.JLabel();
        jComboMes = new javax.swing.JComboBox();
        jSeparator4 = new javax.swing.JToolBar.Separator();
        jBtnCompras = new javax.swing.JButton();
        jSeparator5 = new javax.swing.JToolBar.Separator();
        jBtnDeposito = new javax.swing.JButton();
        jSeparator1 = new javax.swing.JSeparator();
        jTabbedPane1 = new javax.swing.JTabbedPane();
        jPanel1 = new javax.swing.JPanel();
        jScrollPane2 = new javax.swing.JScrollPane();
        jTableConsultas = new javax.swing.JTable();
        jLabel3 = new javax.swing.JLabel();
        jTxtTotal = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        jTxtAhorro = new javax.swing.JTextField();
        jSeparator2 = new javax.swing.JSeparator();
        jLabel2 = new javax.swing.JLabel();
        jCheckDisco = new javax.swing.JCheckBox();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jLabel1.setText("Tipo de Gasto:");

        jComboTipo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jComboTipoActionPerformed(evt);
            }
        });

        jTableGastos.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null}
            },
            new String [] {
                "Fecha", "Descripcion", "Monto"
            }
        ) {
            Class[] types = new Class [] {
                java.lang.Object.class, java.lang.String.class, java.lang.Double.class
            };

            public Class getColumnClass(int columnIndex) {
                return types [columnIndex];
            }
        });
        jTableGastos.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                jTableGastosKeyPressed(evt);
            }
        });
        jScrollPane1.setViewportView(jTableGastos);

        jBtnAdd.setIcon(new javax.swing.ImageIcon(getClass().getResource("/list-add.png"))); // NOI18N
        jBtnAdd.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jBtnAddActionPerformed(evt);
            }
        });

        jBtnRemove.setIcon(new javax.swing.ImageIcon(getClass().getResource("/list-remove.png"))); // NOI18N
        jBtnRemove.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jBtnRemoveActionPerformed(evt);
            }
        });

        jBtnGuardar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/document-save.png"))); // NOI18N
        jBtnGuardar.setText("Guardar");
        jBtnGuardar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jBtnGuardarActionPerformed(evt);
            }
        });

        jToolBar1.setFloatable(false);
        jToolBar1.setRollover(true);

        jBtnAgregar.setText("Agregar");
        jBtnAgregar.setFocusable(false);
        jBtnAgregar.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        jBtnAgregar.setSelected(true);
        jBtnAgregar.setVerticalTextPosition(javax.swing.SwingConstants.BOTTOM);
        jBtnAgregar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jBtnAgregarActionPerformed(evt);
            }
        });
        jToolBar1.add(jBtnAgregar);

        jBtnModificar.setText("Modificar");
        jBtnModificar.setFocusable(false);
        jBtnModificar.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        jBtnModificar.setVerticalTextPosition(javax.swing.SwingConstants.BOTTOM);
        jBtnModificar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jBtnModificarActionPerformed(evt);
            }
        });
        jToolBar1.add(jBtnModificar);

        jBtnEliminar.setText("Eliminar");
        jBtnEliminar.setFocusable(false);
        jBtnEliminar.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        jBtnEliminar.setVerticalTextPosition(javax.swing.SwingConstants.BOTTOM);
        jBtnEliminar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jBtnEliminarActionPerformed(evt);
            }
        });
        jToolBar1.add(jBtnEliminar);
        jToolBar1.add(jSeparator3);

        jLabel5.setText("Mes: ");
        jToolBar1.add(jLabel5);

        jComboMes.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" }));
        jComboMes.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jComboMesActionPerformed(evt);
            }
        });
        jToolBar1.add(jComboMes);
        jToolBar1.add(jSeparator4);

        jBtnCompras.setText("Comprar");
        jBtnCompras.setFocusable(false);
        jBtnCompras.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        jBtnCompras.setVerticalTextPosition(javax.swing.SwingConstants.BOTTOM);
        jBtnCompras.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jBtnComprasActionPerformed(evt);
            }
        });
        jToolBar1.add(jBtnCompras);
        jToolBar1.add(jSeparator5);

        jBtnDeposito.setText("Deposito");
        jBtnDeposito.setFocusable(false);
        jBtnDeposito.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        jBtnDeposito.setVerticalTextPosition(javax.swing.SwingConstants.BOTTOM);
        jBtnDeposito.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jBtnDepositoActionPerformed(evt);
            }
        });
        jToolBar1.add(jBtnDeposito);

        jSeparator1.setOrientation(javax.swing.SwingConstants.VERTICAL);

        jTableConsultas.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Fecha", "Descripcion", "Monto"
            }
        ));
        jTableConsultas.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
        jScrollPane2.setViewportView(jTableConsultas);

        jLabel3.setText("Total:");

        jTxtTotal.setEditable(false);

        jLabel4.setText("Ahorro:");

        jTxtAhorro.setEditable(false);

        jSeparator2.setOrientation(javax.swing.SwingConstants.VERTICAL);

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 422, Short.MAX_VALUE)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel4)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jTxtAhorro, javax.swing.GroupLayout.PREFERRED_SIZE, 134, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jSeparator2, javax.swing.GroupLayout.DEFAULT_SIZE, 6, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jLabel3)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jTxtTotal, javax.swing.GroupLayout.PREFERRED_SIZE, 134, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 266, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(jTxtTotal, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(jLabel3)
                        .addComponent(jLabel4)
                        .addComponent(jTxtAhorro, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(jSeparator2, javax.swing.GroupLayout.DEFAULT_SIZE, 33, Short.MAX_VALUE))
                .addContainerGap())
        );

        jTabbedPane1.addTab("Gastos Mes", jPanel1);

        jLabel2.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel2.setText("Consultas");

        jCheckDisco.setText("Compra Disco");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jBtnAdd)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jBtnRemove)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(jCheckDisco)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jBtnGuardar))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel1)
                        .addGap(18, 18, 18)
                        .addComponent(jComboTipo, javax.swing.GroupLayout.PREFERRED_SIZE, 183, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 433, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jSeparator1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel2, javax.swing.GroupLayout.DEFAULT_SIZE, 418, Short.MAX_VALUE)
                        .addGap(12, 12, 12))
                    .addComponent(jTabbedPane1)))
            .addComponent(jToolBar1, javax.swing.GroupLayout.DEFAULT_SIZE, 899, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel1)
                            .addComponent(jComboTipo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 284, Short.MAX_VALUE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jCheckDisco)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                .addComponent(jBtnGuardar, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(jBtnRemove, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(jBtnAdd, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))))
                    .addComponent(jSeparator1, javax.swing.GroupLayout.DEFAULT_SIZE, 371, Short.MAX_VALUE)
                    .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                        .addComponent(jLabel2)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jTabbedPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 348, Short.MAX_VALUE)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jToolBar1, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE))
        );

        jTabbedPane1.getAccessibleContext().setAccessibleName("GastosMes");

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jBtnAddActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jBtnAddActionPerformed
        Vector row = new Vector();
        Date fecha = new Date();
        row.add(fecha.getDate() + "/" + (fecha.getMonth() + 1) + "/" + (fecha.getYear() + 1900));
        row.add("");
        double monto = 0;
        row.add(monto);
        this.defaultTable.addRow(row);
        this.jTableGastos.setDefaultRenderer(this.jTableGastos.getColumnClass(0), miRender);
    }//GEN-LAST:event_jBtnAddActionPerformed

    private void jBtnRemoveActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jBtnRemoveActionPerformed
        int selectedRow = this.jTableGastos.getSelectedRow();
        this.defaultTable.removeRow(selectedRow);
    }//GEN-LAST:event_jBtnRemoveActionPerformed

    private void jTableGastosKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_jTableGastosKeyPressed
        if ((evt.getKeyChar() == 9) && (this.jTableGastos.getSelectedColumn() == (this.jTableGastos.getColumnCount() - 1)) && 
                (this.jTableGastos.getSelectedRow() == (this.jTableGastos.getRowCount() - 1)) &&
                !this.jBtnModificar.isSelected()) {
            Vector row = new Vector();
            Date fecha = new Date();
            row.add(fecha.getDate() + "/" + (fecha.getMonth() + 1) + "/" + (fecha.getYear() + 1900));
            row.add("");
            double monto = 0;
            row.add(monto);
            this.defaultTable.addRow(row);
            this.jTableGastos.setDefaultRenderer(this.jTableGastos.getColumnClass(0), miRender);
        }
    }//GEN-LAST:event_jTableGastosKeyPressed

    private void jBtnGuardarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jBtnGuardarActionPerformed
        if (this.jBtnAgregar.isSelected()) {
            if(this.jCheckDisco.isSelected() && this.jTableGastos.getRowCount() > 1){
                pane.showMessageDialog(null, "Para las compras de Disco\ndebe haber " +
                        "solo un elemento en la lista", "Compra Disco",
                        javax.swing.JOptionPane.PLAIN_MESSAGE);
            }else{
                this.save();
            }
        }else if(this.jBtnModificar.isSelected()){
            if(this.jCheckDisco.isSelected() && this.jTableGastos.getRowCount() > 1){
                pane.showMessageDialog(null, "Para las compras de Disco\ndebe haber " +
                        "solo un elemento en la lista", "Compra Disco",
                        javax.swing.JOptionPane.PLAIN_MESSAGE);
            }else{
                this.modify();
            }
        }

        this.jBtnAgregarActionPerformed(null);
    }//GEN-LAST:event_jBtnGuardarActionPerformed

    private void actualizar() {
        if(!this.update) return;
        this.defaultConsultas.setDataVector(new Vector(), titulos);
        Gasto gasto = new Gasto();
        gasto.setSql("month(fecha) = " + (this.jComboMes.getSelectedIndex() + 1));

        //Order By
        gasto.setSql(gasto.getSql() + " ORDER BY fecha ASC");

        this.consultas = admin.obtainAll(gasto);

        int size = this.consultas.size();
        String tipo = ((TipoGasto)this.jComboTipo.getSelectedItem()).getTipo();
        for (int i = 0; i < size; i++) {
            Vector datos = new Vector();
            Gasto g = (Gasto) this.consultas.get(i);
            if(!g.getTipo().getTipo().equalsIgnoreCase(tipo)) continue;
            datos.add(g.getFecha().toString());
            datos.add(g.getDescripcion());
            datos.add(g.getMonto());
            this.defaultConsultas.addRow(datos);
        }
        this.jTableConsultas.setDefaultRenderer(this.jTableConsultas.getColumnClass(0), miRender);

        int rows = this.jTableConsultas.getRowCount();
        double total = 0;
        for(int i=0; i < rows; i++){
            total += (Double) this.jTableConsultas.getValueAt(i, 2);
        }

        DecimalFormat decimal = new DecimalFormat("0.##");
        this.jTxtAhorro.setText(decimal.format(total));
        if(tipo.equalsIgnoreCase("Generales")){
            this.jTxtTotal.setText(decimal.format(1400-total));
        }else{
            this.jTxtTotal.setText(decimal.format(300-total));
        }
    }

    private void jBtnAgregarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jBtnAgregarActionPerformed
        this.jBtnModificar.setSelected(false);
        this.jBtnEliminar.setSelected(false);
        this.jBtnAgregar.setSelected(true);
        this.jBtnAdd.setEnabled(true);
        this.jBtnRemove.setEnabled(true);
        this.jComboTipo.setEnabled(true);
    }//GEN-LAST:event_jBtnAgregarActionPerformed

    private void jComboMesActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jComboMesActionPerformed
        this.actualizar();
    }//GEN-LAST:event_jComboMesActionPerformed

    private void jComboTipoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jComboTipoActionPerformed
        this.actualizar();
    }//GEN-LAST:event_jComboTipoActionPerformed

    private void jBtnDepositoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jBtnDepositoActionPerformed
        if(pane.showConfirmDialog(null, "Desea realizar el deposito?",
                "Deposito", pane.YES_NO_OPTION) == pane.YES_OPTION){
            for(TipoGasto tipo : this.tipos){
                Gasto gasto;
                if(tipo.getTipo().equalsIgnoreCase("Generales")){
                    gasto = new Gasto(new Date(), "Deposito Mes", 1400, tipo);
                }else{
                    gasto = new Gasto(new Date(), "Deposito Mes", 300, tipo);
                }

                admin.save(gasto);
            }
            pane.showMessageDialog(null, "Deposito Realizado!",
                        "Deposito", javax.swing.JOptionPane.PLAIN_MESSAGE);
        }
    }//GEN-LAST:event_jBtnDepositoActionPerformed

    private void jBtnEliminarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jBtnEliminarActionPerformed
        if(this.jTableConsultas.getSelectedRow() > -1){
            Gasto gasto = (Gasto) this.consultas.get(
                    this.jTableConsultas.getSelectedRow()+1);

            gasto.setSql("id = " + gasto.getId());
            admin.delete(gasto);
            this.actualizar();
        }
    }//GEN-LAST:event_jBtnEliminarActionPerformed

    private void jBtnModificarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jBtnModificarActionPerformed
        if(this.jTableConsultas.getSelectedRow() > -1){
            this.modificar = (Gasto) this.consultas.get(
                    this.jTableConsultas.getSelectedRow()+1);

            this.modificar.setSql("id = " + this.modificar.getId());

            Vector datos = new Vector();
            datos.add(this.modificar.getFecha().toString());
            datos.add(this.modificar.getDescripcion());
            datos.add(-this.modificar.getMonto());
            this.defaultTable.addRow(datos);
            this.jTableGastos.setDefaultRenderer(this.jTableGastos.getColumnClass(0), miRender);

            this.jBtnAdd.setEnabled(false);
            this.jBtnRemove.setEnabled(false);
            this.jBtnModificar.setSelected(true);
            this.jBtnAgregar.setSelected(false);
            this.jComboTipo.setEnabled(false);
        }
    }//GEN-LAST:event_jBtnModificarActionPerformed

    private void jBtnComprasActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jBtnComprasActionPerformed
        ComprasGui compras = new ComprasGui(this, true, admin);
        compras.setVisible(true);
    }//GEN-LAST:event_jBtnComprasActionPerformed

    private void modify(){
        try {
            Date fecha = new Date();
            double monto = 0;
            String rowFecha = (String) this.jTableGastos.getValueAt(0, 0);
            String rowDesc = (String) this.jTableGastos.getValueAt(0, 1);
            monto = Double.parseDouble(String.valueOf(this.jTableGastos.getValueAt(0, 2)));
            String[] values = rowFecha.split("-");
            fecha.setDate(Integer.parseInt(values[2]));
            fecha.setMonth(Integer.parseInt(values[1]) - 1);
            fecha.setYear(Integer.parseInt(values[0]) - 1900);
            this.modificar.setFecha(new java.sql.Date(fecha.getTime()));
            this.modificar.setDescripcion(rowDesc);
            this.modificar.setMonto(-monto);
            this.modificar.setTipo(this.tipos.get(this.jComboTipo.getSelectedIndex()));

            admin.setDropDown(false);
            admin.modify(this.modificar);
            admin.setDropDown(true);

            if(this.jCheckDisco.isSelected()){
                Gasto gasto = new Gasto(fecha, "Devolucion Disco",
                        (monto*0.15), this.tipos.get(this.jComboTipo.getSelectedIndex()));
                admin.save(gasto);
            }

            this.defaultTable.setDataVector(new Vector(), titulos);
            pane.showMessageDialog(null, "Los datos se han guardado correctamente",
                    "Datos Guardados", javax.swing.JOptionPane.PLAIN_MESSAGE);
        } catch (Exception e) {
            e.printStackTrace();
            pane.showMessageDialog(null, "No se pudieron guardar los datos.\n" +
                    "Algunos de los datos pueden estar en un formato incorrecto\n" +
                    "Revise el Formato y Vuelva a intentarlo...", "Datos Incorrectos",
                    javax.swing.JOptionPane.ERROR_MESSAGE);
        }finally{
            this.actualizar();
            this.jCheckDisco.setSelected(false);
        }
    }

    private void save() {
        try {
            int cant = this.jTableGastos.getRowCount();
            ArrayList array = new ArrayList();
            Date fecha = new Date();
            double monto = 0;
            for (int i = 0; i < cant; i++) {
                String rowFecha = (String) this.jTableGastos.getValueAt(i, 0);
                String rowDesc = (String) this.jTableGastos.getValueAt(i, 1);
                String rowMonto = (String) this.jTableGastos.getValueAt(i, 2);
                String[] values = rowFecha.split("/");
                fecha.setDate(Integer.parseInt(values[0]));
                fecha.setMonth(Integer.parseInt(values[1]) - 1);
                fecha.setYear(Integer.parseInt(values[2]) - 1900);
                monto = Double.parseDouble(rowMonto);
                Gasto gasto = new Gasto(fecha, rowDesc, -monto,
                        this.tipos.get(this.jComboTipo.getSelectedIndex()));
                gasto.setFecha(new java.sql.Date(fecha.getTime()));
                array.add(gasto);
            }

            if(this.jCheckDisco.isSelected()){
                Gasto gasto = new Gasto(fecha, "Devolucion Disco",
                        (monto*0.15), this.tipos.get(this.jComboTipo.getSelectedIndex()));
                array.add(gasto);
            }

            admin.saveAll(array);

            this.defaultTable.setDataVector(new Vector(), titulos);
            pane.showMessageDialog(null, "Los datos se han guardado correctamente",
                    "Datos Guardados", javax.swing.JOptionPane.PLAIN_MESSAGE);
        } catch (Exception e) {
            pane.showMessageDialog(null, "No se pudieron guardar los datos.\n" +
                    "Algunos de los datos pueden estar en un formato incorrecto\n" +
                    "Revise el Formato y Vuelva a intentarlo...", "Datos Incorrectos",
                    javax.swing.JOptionPane.ERROR_MESSAGE);
        }finally{
            this.actualizar();
            this.jCheckDisco.setSelected(false);
        }
    }

    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {

            public void run() {
                try {
                    UIManager.setLookAndFeel("org.jvnet.substance.skin.SubstanceMistAquaLookAndFeel");
                } catch (Exception e) {
                    try {
                        UIManager.setLookAndFeel("com.sun.java.swing.plaf.gtk.GTKLookAndFeel");
                    } catch (Exception ee) {
                        ee.printStackTrace();
                    }
                }
                new GastosGui().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jBtnAdd;
    private javax.swing.JButton jBtnAgregar;
    private javax.swing.JButton jBtnCompras;
    private javax.swing.JButton jBtnDeposito;
    private javax.swing.JButton jBtnEliminar;
    private javax.swing.JButton jBtnGuardar;
    private javax.swing.JButton jBtnModificar;
    private javax.swing.JButton jBtnRemove;
    private javax.swing.JCheckBox jCheckDisco;
    private javax.swing.JComboBox jComboMes;
    private javax.swing.JComboBox jComboTipo;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JSeparator jSeparator1;
    private javax.swing.JSeparator jSeparator2;
    private javax.swing.JToolBar.Separator jSeparator3;
    private javax.swing.JToolBar.Separator jSeparator4;
    private javax.swing.JToolBar.Separator jSeparator5;
    private javax.swing.JTabbedPane jTabbedPane1;
    private javax.swing.JTable jTableConsultas;
    private javax.swing.JTable jTableGastos;
    private javax.swing.JToolBar jToolBar1;
    private javax.swing.JTextField jTxtAhorro;
    private javax.swing.JTextField jTxtTotal;
    // End of variables declaration//GEN-END:variables
}
