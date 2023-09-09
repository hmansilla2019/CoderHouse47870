// See https://aka.ms/new-console-template for more information
using AppBanco;

float tasa = 0;

Cuenta cuenta = new Cuenta();
Console.WriteLine("Cuenta Default");
Console.WriteLine("Nro Cuenta " + cuenta.NroCuenta + Environment.NewLine
                  + "Fecha de Apertura " + cuenta.FechaApertura + Environment.NewLine
                  + "Saldo " + cuenta.Saldo + Environment.NewLine
                  + "Tipo de Interes" + cuenta.TipoInteres);

cuenta.NroCuenta = 1;
cuenta.FechaApertura = new DateTime(2023, 8, 8);
cuenta.Saldo = 10000.00f;
cuenta.TipoInteres = "Variable";
Console.WriteLine("Cuenta Modificada");
Console.WriteLine("Nro Cuenta " + cuenta.NroCuenta + Environment.NewLine
                  + "Fecha de Apertura " + cuenta.FechaApertura + Environment.NewLine
                  + "Saldo " + cuenta.Saldo + Environment.NewLine
                  + "Tipo de Interes" + cuenta.TipoInteres);

Cuenta myCuenta = new Cuenta(2, 50000, new DateTime(2023, 5, 5), "Fija");
Console.WriteLine("Cuenta Modificada 2");
Console.WriteLine("Nro Cuenta " + myCuenta.NroCuenta + Environment.NewLine
                  + "Fecha de Apertura " + myCuenta.FechaApertura + Environment.NewLine
                  + "Saldo " + myCuenta.Saldo + Environment.NewLine
                  + "Tipo de Interes" + myCuenta.TipoInteres);

myCuenta.Depositar(50000);
Console.WriteLine("Su saldo es " + myCuenta.Saldo);

myCuenta.Extraer(100000);
Console.WriteLine("Su saldo es " + myCuenta.Saldo);

tasa = myCuenta.CalcularTasa(myCuenta.TipoInteres);

Console.WriteLine("La tasa es del " + tasa + "%");

CajaAhorro cajaAhorro = new CajaAhorro();
cajaAhorro.Saldo = 50000;
cajaAhorro.NroCuenta = 2;
cajaAhorro.FechaApertura = new DateTime(2023, 5, 5);
cajaAhorro.TipoInteres = "Variable";
cajaAhorro.NroCuentaEspecial = "1234";

Console.WriteLine("Nro Cuenta " + cajaAhorro.NroCuenta + Environment.NewLine
                  + "Fecha de Apertura " + cajaAhorro.FechaApertura + Environment.NewLine
                  + "Saldo " + cajaAhorro.Saldo + Environment.NewLine
                  + "Tipo de Interes " + cajaAhorro.TipoInteres + Environment.NewLine
                  + "Nro Cuenta Especial " + cajaAhorro.NroCuentaEspecial);



CuentaCorriente ctacte = new CuentaCorriente();
ctacte.Saldo = 50000;
ctacte.NroCuenta = 2;
ctacte.FechaApertura = new DateTime(2023, 5, 5);
ctacte.TipoInteres = "Variable";
ctacte.NroCuentaEspecial = "1234";

Console.WriteLine("Nro Cuenta " + ctacte.NroCuenta + Environment.NewLine
                  + "Fecha de Apertura " + ctacte.FechaApertura + Environment.NewLine
                  + "Saldo " + ctacte.Saldo + Environment.NewLine
                  + "Tipo de Interes" + ctacte.TipoInteres
                   + "Nro Cuenta Especial " + ctacte.NroCuentaEspecial);

Console.ReadKey();
