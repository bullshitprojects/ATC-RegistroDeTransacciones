using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SistemaDePagoEmpleados;
using RegistroDeTransacciones.Clases;

namespace RegistroDeTransacciones
{
    class Conexionbd
    {
        List<LibroDiario> libroDiario = new List<LibroDiario>();
        List<BalanceDeComprobacion> lBalanceDeComprobacion = new List<BalanceDeComprobacion>();
        BalanceDeComprobacion oBalanceDeComprobacion = new BalanceDeComprobacion();
        List<Mayorizacion> lMayorizacion = new List<Mayorizacion>();
        Mayorizacion oMayorizacion = new Mayorizacion();
        List<CatalogoDeCuentas> lCatalogo = new List<CatalogoDeCuentas>();
        CatalogoDeCuentas oCatalogo = new CatalogoDeCuentas();
        Empresa oEmpresa = new Empresa();

        //Cadena de Conexion
        //string cadena = "data source = ASUS\\SQLEXPRESS; initial catalog = RegistroDeTransacciones; Integrated Security=True";
        string cadena = "server=remotemysql.com;port=3306; database=5M7XK24K7a;uid=5M7XK24K7a;password=4lSHKSOmEH;";

        public MySqlConnection Conectarbd;
        MySqlCommand cmd;
        MySqlDataReader dr;

        //Constructor
        public Conexionbd()
        {
            Conectarbd = new MySqlConnection(cadena);
        }

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                Conectarbd.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }
        }

        //Metodo para Agregar un Asiento contable
        public string InsertarAsiento(string codigo, string cuenta, string concepto, string fecha, string asiento, string orden, string naturaleza, double valor)
        {
            string salida = "Asiento Insertado Con Exito";
            try
            { 
                if (naturaleza == "Parcial")
                {
                    cmd = new MySqlCommand("Insert into LibroDiario (fecha, asiento, orden, codigo, cuenta, concepto, parcial, debe, haber) " +
                     "values('" + fecha + "','" + asiento + "','" + orden + "','" + codigo + "','" + cuenta + "','" + concepto + "','" + valor + "','" + 0 + "','" + 0 + "')", Conectarbd);
                }
                if (naturaleza == "Debe")
                {
                    cmd = new MySqlCommand("Insert into LibroDiario (fecha, asiento, orden, codigo, cuenta, concepto, parcial, debe, haber) " +
                     "values('" + fecha + "','" + asiento + "','" + orden + "','" + codigo + "','" + cuenta + "','" + concepto + "','" + 0 + "','" + valor + "','" + 0 + "')", Conectarbd);
                }
                if (naturaleza == "Haber")
                {
                    cmd = new MySqlCommand("Insert into LibroDiario (fecha, asiento, orden, codigo, cuenta, concepto, parcial, debe, haber) " +
                     "values('" + fecha + "','" + asiento + "','" + orden + "','" + codigo + "','" + cuenta + "','" + concepto + "','" + 0 + "','" + 0 + "','" + valor + "')", Conectarbd);
                }
                abrir();
                cmd.ExecuteNonQuery();
                cerrar();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                cerrar();
            }
            return salida;
        }


        public List <LibroDiario> CargarLibroDiario()
        {
            try
            {              
                libroDiario = new List<LibroDiario>();              
                cmd = new MySqlCommand("select * from LibroDiario order by asiento, orden", Conectarbd);
                abrir();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LibroDiario Transaccion = new LibroDiario();
                    Transaccion.Fecha = dr.GetString(1);
                    Transaccion.Asiento = dr.GetString(2);
                    Transaccion.Orden = dr.GetString(3);
                    Transaccion.Codigo = dr.GetString(4);
                    Transaccion.Cuenta = dr.GetString(5);
                    Transaccion.Concepto = dr.GetString(6);
                    Transaccion.Parcial = Convert.ToDouble(dr.GetValue(7).ToString());
                    Transaccion.Debe = Convert.ToDouble(dr.GetValue(8).ToString());
                    Transaccion.Haber = Convert.ToDouble(dr.GetValue(9).ToString());
                    libroDiario.Add(Transaccion);
                }
                dr.Close();
                cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return libroDiario;
        }

        public List<BalanceDeComprobacion> BalanceDeComprobacion()
        {
            try
            {
                lBalanceDeComprobacion = new List<BalanceDeComprobacion>();
                double movimientoDeudor = 0;
                double movimientoAcreedor = 0;
                double saldoDeudor = 0;
                double saldoAcreedor = 0;
                
                Conectarbd = new MySqlConnection(cadena);
                cmd = new MySqlCommand(" select codigo, cuenta,  sum(debe) as deudor, sum(haber) as acreedor  from LibroDiario Group by codigo, cuenta Order by codigo", Conectarbd);
                abrir();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    oBalanceDeComprobacion = new BalanceDeComprobacion();
                    oBalanceDeComprobacion.Codigo = dr.GetString(0);
                    oBalanceDeComprobacion.Cuenta = dr.GetString(1);
                    oBalanceDeComprobacion.MovimientoDeudor = Convert.ToDouble(dr.GetValue(2).ToString());
                    oBalanceDeComprobacion.MovimientoAcreedor = Convert.ToDouble(dr.GetValue(3).ToString());
                    double comprobacion = oBalanceDeComprobacion.MovimientoDeudor - oBalanceDeComprobacion.MovimientoAcreedor;
                    if (comprobacion >= 0)
                    {
                        oBalanceDeComprobacion.SaldoDeudor = comprobacion;
                        oBalanceDeComprobacion.SaldoAcreedor = 0;
                    }
                    else
                    {
                        oBalanceDeComprobacion.SaldoDeudor = 0;
                        oBalanceDeComprobacion.SaldoAcreedor = comprobacion*-1;
                    }
                    movimientoDeudor += oBalanceDeComprobacion.MovimientoDeudor;
                    movimientoAcreedor += oBalanceDeComprobacion.MovimientoAcreedor;
                    saldoDeudor += oBalanceDeComprobacion.SaldoDeudor;
                    saldoAcreedor += oBalanceDeComprobacion.SaldoAcreedor;
                    lBalanceDeComprobacion.Add(oBalanceDeComprobacion);
                }
                dr.Close();
                oBalanceDeComprobacion = new BalanceDeComprobacion();
                oBalanceDeComprobacion.Cuenta = "           Sumas Iguales";
                oBalanceDeComprobacion.MovimientoDeudor = movimientoDeudor;
                oBalanceDeComprobacion.MovimientoAcreedor = movimientoAcreedor;
                oBalanceDeComprobacion.SaldoDeudor = saldoDeudor;
                oBalanceDeComprobacion.SaldoAcreedor = saldoAcreedor;
                lBalanceDeComprobacion.Add(oBalanceDeComprobacion);

                cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return lBalanceDeComprobacion;
        }

        public List<Mayorizacion> Mayorizacion()
        {
            try
            {
                lMayorizacion = new List<Mayorizacion>();
                string cuentaFlotante = "";
                double totalDebe = 0;
                double totalHaber = 0;
                double saldo = 0;
                int acesso = 0;
                abrir();
                cmd = new MySqlCommand("select fecha, codigo, cuenta, concepto, debe, haber from LibroDiario Order by codigo, cuenta , asiento", Conectarbd);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (cuentaFlotante != dr.GetString(1))
                    {
                        if (acesso == 1)
                        {
                            //Fila de totales
                            oMayorizacion = new Mayorizacion();
                            oMayorizacion.Fecha = "";
                            oMayorizacion.Codigo = "";
                            oMayorizacion.Concepto = "                                Total";

                            oMayorizacion.Debe = "$  " + Convert.ToString(totalDebe);
                            oMayorizacion.Haber = "$  " + Convert.ToString(totalHaber);
                            oMayorizacion.Saldo = "$  " + Convert.ToString(saldo);
                            lMayorizacion.Add(oMayorizacion);

                            //Fila en blanco
                            oMayorizacion = new Mayorizacion();
                            lMayorizacion.Add(oMayorizacion);

                            totalDebe = 0;
                            totalHaber = 0;
                            saldo = 0;
                        }

                        acesso = 1;

                    }


                    oMayorizacion = new Mayorizacion();
                    oMayorizacion.Fecha = dr.GetString(0);
                    oMayorizacion.Codigo = dr.GetString(1);
                    oMayorizacion.Cuenta = dr.GetString(2);
                    oMayorizacion.Concepto = dr.GetString(3);
                    oMayorizacion.Debe = "$  " + (dr.GetValue(4).ToString());
                    oMayorizacion.Haber = "$  " + (dr.GetValue(5).ToString());

                    if (saldo + (Convert.ToDouble(dr.GetValue(4).ToString()) - Convert.ToDouble(dr.GetValue(5).ToString()))<0)
                    {
                        oMayorizacion.Saldo = "$  " +  Convert.ToString(saldo + (Convert.ToDouble(dr.GetValue(4).ToString()) - Convert.ToDouble(dr.GetValue(5).ToString())) * -1);
                        saldo += ((Convert.ToDouble(dr.GetValue(4).ToString()) - Convert.ToDouble(dr.GetValue(5).ToString()))) *-1;
                    }
                    else
                    {
                        oMayorizacion.Saldo = "$  " + Convert.ToString(saldo + (Convert.ToDouble(dr.GetValue(4).ToString()) - Convert.ToDouble(dr.GetValue(5).ToString())));
                        saldo += (Convert.ToDouble(dr.GetValue(4).ToString()) - Convert.ToDouble(dr.GetValue(5).ToString()));
                    }
                    

                    cuentaFlotante = oMayorizacion.Codigo;
                    totalDebe += Convert.ToDouble(dr.GetValue(4).ToString());
                    totalHaber += Convert.ToDouble(dr.GetValue(5).ToString());

                    lMayorizacion.Add(oMayorizacion);

                }
                dr.Close();

                cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return lMayorizacion;
        }

        public List<CatalogoDeCuentas> CargarCatalogoDeCuentas()
        {
            try
            {
                lCatalogo = new List<CatalogoDeCuentas>();
                abrir();
                cmd = new MySqlCommand("select * from catalogo_cuenta order by codigo", Conectarbd);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    oCatalogo = new CatalogoDeCuentas();
                    oCatalogo.Naturaleza = dr.GetString(1);
                    oCatalogo.Codigo = dr.GetString(2);
                    oCatalogo.Cuenta = dr.GetString(3);
                    lCatalogo.Add(oCatalogo);
                }
                dr.Close();
                cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return lCatalogo;
        }


        //Metodo para Agregar un Asiento contable
        public string AgregarEmpresa(string empresa, string nit, string razonSocial, string email, string usuario, string contra)
        {
            string salida = "Empresa Agregada Con Exito";
            try
            {          
                cmd = new MySqlCommand("Insert into empresa (nEmpresa, nitEmpresa, razonSocial, email, usuario, contra) " +
                "values('" + empresa + "','" + nit + "','" + razonSocial + "','" + email + "','" + usuario + "','" + contra + "')", Conectarbd);
                abrir();
                cmd.ExecuteNonQuery();
                cerrar();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                cerrar();
            }
            return salida;
        }

        //Metodo para Modificar Empresa
        public string ModificarEmpresa(string empresa, string nit, string razonSocial, string email, string usuario, string contra)
        {
            string salida = "Empresa Modificada Con Exito";
            try
            {            
                cmd = new MySqlCommand("Update empresa set nEmpresa= '" + empresa + "', nitEmpresa= '" + nit + "', razonSocial= '" + razonSocial + "', email= '" + email + "', usuario= '" + usuario + "', contra= '" + contra + "'", Conectarbd);
                abrir();
                cmd.ExecuteNonQuery();
                cerrar();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                cerrar();
            }
            return salida;
        }

        public int ConsultarEmpresa()
        {
            int contador=0;
            try
            {               
                
                Conectarbd = new MySqlConnection(cadena);
                cmd = new MySqlCommand("select * from empresa", Conectarbd);
                abrir();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador += 1;
                }
                dr.Close();
                cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        public int Login(string usuario, string contra)
        {
            int validar = 0;
            try
            {
               
                Conectarbd = new MySqlConnection(cadena);
                cmd = new MySqlCommand("select usuario, contra from empresa", Conectarbd);
                abrir();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.GetString(0)==usuario && dr.GetString(1)==contra)
                    {
                        validar = 1;
                    }
                }
                dr.Close();
                cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return validar;
        }

        //Metodo para Eliminar La empresa y todos sus registros
        public string EliminarEmpresa()
        {
            string salida = "Empresa y Todos sus registros fueron eliminados con exito";
            try
            {
                abrir();
                cmd = new MySqlCommand("DELETE FROM empresa", Conectarbd);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand("DELETE FROM LibroDiario", Conectarbd);
                cmd.ExecuteNonQuery();
                cerrar();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                cerrar();
            }
            return salida;
        }

        //Metodo para Eliminar La empresa y todos sus registros
        public string EliminarAsiento(string asiento, string orden)
        {
            string salida = "Asiento Eliminado";
            try
            {
               
                cmd = new MySqlCommand("DELETE FROM LibroDiario WHERE asiento = '" + asiento + "' and orden= '" + orden + "'", Conectarbd);
                abrir();
                cmd.ExecuteNonQuery();
                cerrar();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                cerrar();
            }
            return salida;
        }

        public Empresa CargarEmpresa()
        {
            try
            {
                oEmpresa = new Empresa();
                
                cmd = new MySqlCommand("select * from empresa", Conectarbd);
                abrir();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    oEmpresa.NEmpresa = dr.GetString(1);
                    oEmpresa.NitEmpresa = dr.GetString(2);
                    oEmpresa.RazonSocial = dr.GetString(3);
                    oEmpresa.Email = dr.GetString(4);
                    oEmpresa.Usuario = dr.GetString(5);
                    oEmpresa.Contra = dr.GetString(6);
                }
                dr.Close();
                cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return oEmpresa;
        }

        //Metodo para Agregar una cuenta
        public string InsertarCuenta(string codigo, string cuenta, string naturaleza)
        {
            string salida = "Asiento Insertado Con Exito";
            try
            {
                
                cmd = new MySqlCommand("Insert into catalogo_cuenta (naturaleza, codigo, cuenta) " +
                "values('" + naturaleza + "','" + codigo + "','" + cuenta + "')", Conectarbd);
                abrir();
                cmd.ExecuteNonQuery();
                cerrar();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                cerrar();
            }
            return salida;
        }


        public string EliminarCuenta(string codigo, string cuenta)
        {
            string salida = "Cuenta Eliminado";
            try
            {
                
                cmd = new MySqlCommand("DELETE FROM catalogo_cuenta WHERE codigo = '" + codigo + "' and cuenta= '" + cuenta + "'", Conectarbd);
                abrir();
                cmd.ExecuteNonQuery();
                cerrar();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                cerrar();
            }
            return salida;
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            Conectarbd.Close();
        }
    }

}
