Create Database RegistroDeTransacciones;
Go

Use RegistroDeTransacciones;
Go

Create Table empresa(
nEmpresa varchar(25) not null, 
nitEmpresa varchar(20) not null,
razonSocial varchar(30) not null,
patrono varchar(50) not null,
nitPatrono varchar(20) not null
); 


Create Table catalogo_cuenta(
id_catalogo_cuenta int not null identity,
naturaleza varchar(8) not null,
codigo varchar(10) not null,
cuenta varchar(50) not null,
);


CREATE TABLE LibroDiario
   (
      id_libro_diario  int IDENTITY(1,1) PRIMARY KEY,
      fecha  varchar(255),
      asiento  varchar(20),
	  orden  varchar(20),
	  codigo  varchar(20),
	  cuenta  varchar(100),
	  concepto  varchar(100),
	  parcial  real,
	  debe  real,
	  haber  real
   )

Insert into empresa(nEmpresa, nitEmpresa, razonSocial, patrono, nitPatrono)  
values ('XYZ', '1234-124578-123-4', 'Venta de Zapatos', 'Jose Martinez', '0210-211091-141-7');

Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1', 'ACTIVO');  
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '11', 'ACTIVOS CORRIENTES');  
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1101', 'EFECTIVO Y EQUIVALENTES DE EFECTIVO');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '110101', 'Caja general');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '11010102', 'Caja chica');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '11010103', 'Bancos');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1101010301', 'Cuenta corriente');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1101010302', 'Cuenta de ahorro');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1101010304', 'Depositos a plazo');  
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1102', 'INVERSIONES A CORTO PLAZO');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '110201', 'Acciones');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '110202', 'Bonos'); 
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '110203', 'Otros titulos valores');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1103', 'CUENTAS POR COBRAR');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1104', 'DOCUMENTOS POR COBRAR');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1105', 'ACCIONISTAS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1106', 'PRESTAMOS A EMPLEADOS Y ACCIONISTAS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '110601', 'Accionistas');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '110602', 'Empleados');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1107', 'OTRAS CUENTAS POR COBRAR');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '110701', 'Anticipos a proveedores');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '110702', 'Anticipos de salarios a empleados');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1108', 'ESTIMACIONES POR CUENTAS INCOBRABLES');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1109', 'INVENTARIOS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1110', 'ESTIMACIONES POR DETERIORO DE INVENTARIO');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1111', 'GASTOS PAGADOS POR ANTICIPADO');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '111101', 'Seguros');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '111102', 'Alquileres');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '111103', 'Papeleria y utiles');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '111104', 'Pago a cuenta');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '111105', 'Otros gastos pagados por anticipado');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1112', 'IVA CREDITO FISCAL');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1113', 'IVA PAGADO POR ANTICIPADO');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '111301', 'IVA Percibido');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '111301', 'IVA Retenido');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1114', 'PAGO A CUENTA');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '12', 'ACTIVOS NO CORRIENTES');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1201', 'PROPIEDAD PLANTA Y EQUIPO');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '120101', 'Terrenos');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '120102', 'Edificios');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '120103', 'Instalaciones');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '120104', 'Equipo de reparto');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '120105', 'Mobiliario y Equipo');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1202', 'DEPRECIACIONES');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '120201', 'Edificio');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '120202', 'Instalaciones');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '120203', 'Edificio');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '120204', 'Mobiliario y equipo');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1203', 'INTANGIBLES');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '120301', 'Credito mercantil');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '120302', 'Patentes y marcas');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '120303', 'Licencias');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1204', 'AMORTIZACION DE INTANGIBLES');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '120401', 'Credito mercantil');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '120402', 'Patentes y maras');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '120403', 'Licencias');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1205', 'INVERSIONES PERMANENTES');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '1206', 'IMPUESTOS SOBRE LA RENTA DIFERIDO');


Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2', 'PASIVO');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '21', 'PASIVOS CORRIENTES');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2101', 'SOBREGIROS BANCARIOS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2102', 'PROVEEDORES');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210201', 'Locales');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210202', 'Extranjeros');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2103', 'DOCUMENTOS POR COBRAR DESCONTADOS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210301', 'Pagares');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210302', 'Letras de cambio');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210303', 'Bonos');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210304', 'Otros titulos valores');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2104', 'DOCUMENTOS POR PAGAR');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210401', 'Pagares');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210402', 'Letras de cambio');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210403', 'Bonos');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210404', 'Otros titulos valores');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2105', 'PRESTAMOS POR PAGAR');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210501', 'Bancarios');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210502', 'Accionistas');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210503', 'Otros');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2106', 'RETENCIONES POR PAGAR');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210601', 'ISSS(salud)');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210602', 'ISSS(pension)');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210603', 'AFP');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210604', 'RENTA');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210605', 'IVA');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2107', 'PROVISIONES POR PAGAR');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210701', 'ISSS(salud)');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210702', 'ISSS(pension)');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210703', 'AFP');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210704', 'INSAFORP');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '210705', 'PAGO A CUENTA');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2108', 'DIVIDENDOS POR PAGAR');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2109', 'IVA DEBITO FISCAL');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2110', 'IVA PERCIBIDO Y RETENIDO POR PAGAR');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '211001', 'IVA Percibido');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '211002', 'IVA Retenido');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2111', 'IMPUESTO POR PAGAR');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '211101', 'Pago a cuenta');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '211102', 'RENTA');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '211103', 'IVA');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '211104', 'Otros');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2112', 'CUENTAS POR PAGAR');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2113', 'INTERESES POR PAGAR');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '22', 'PASIVO NO CORRIENTE');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2201', 'PRESTAMOS POR PAGAR');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2202', 'DOCUMENTOS POR PAGAR');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2203', 'INGRESOS DIFERIDOS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2204', 'PROVISION PARA OBLIGACIONES LABORALES');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '2205', 'PASIVO POR IMPUESTO DE RENTA DIFERIDO');


Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '3', 'PATRIMONIO');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '31', 'CAPITAL CONTABLE');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '3101', 'CAPITAL SOCIAL');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '3102', 'RESERVA LEGAL');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '3103', 'UTILIDADES RETENIDAS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '3104', 'UTILIDAD DEL EJERCICIO');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '3105', 'R PERDIDAS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '310501', 'R Perdidas acumuladas');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '310502', 'R Perdidas del presente ejercicio');


Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '4', 'CUENTAS DE RESULTADO DEUDORAS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '41', 'COSTOS Y GASTOS DE OPERACION');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '4101', 'COMPRAS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '4102', 'GASTOS SOBRE COMPRAS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '4103', 'COSTO DE VENTA');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '42', 'GASTOS OPERATIVOS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '4201', 'GASTOS DE ADMINISTRACION');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420101', 'Sueldos y salarios');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420102', 'Comisiones');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420103', 'Vacaciones');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420104', 'Bonificaciones');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420105', 'Aguinaldos');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420106', 'Horas extras');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420107', 'Viaticos');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420108', 'Indemnizaciones');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420109', 'Atenciones al personal');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420110', 'ISSS(salud)');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420111', 'ISSS(pension)');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420112', 'AFP');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420113', 'Honorarios');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420115', 'Seguros');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420116', 'Transportes');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420117', 'Agua');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420118', 'Comunicaciones');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420119', 'Energia electrica');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420120', 'Estimacion para ceuntas incobrables');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420121', 'Papeleria y utiles');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420122', 'Depreciacion');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420123', 'Matenimiento y reparacion de mobiliario y equipo');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420124', 'Mantenimiento y reparacion de edificios');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420125', 'Matenimiento y reparaciones de equipo de reparto');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420126', 'Publicidad');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420127', 'Empaques');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420128', 'Atenciones a clientes');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420129', 'Multas');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420130', 'Combustibles y lubricantes');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420131', 'Impuestos municipales');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420132', 'Inscripciones');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420133', 'Limpiezas');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420134', 'Alquileres');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420135', 'Matriculas de comercio');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420136', 'Donaciones y contribuciones');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420137', 'Vigilancias');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420138', 'Uniformes');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420139', 'Amortizaciones');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420140', 'Ornatos');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '420141', 'Otros');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '4201', 'GASTOS DE ADMINISTRACION');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '4202', 'GASTOS DE VENTAS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '4203', 'REBAJAS Y DEVOLUCIONES SOBRE VENTAS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '4204', 'DESCUENTOS SOBRE VENTAS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '43', 'GASTOS NO OPERATIVOS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '4301', 'GASTOS FINANCIEROS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '430101', 'Intereses');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '430102', 'Comisiones bancarias');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '430103', 'Diferencial cambiario');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '4302', 'PERDIDAS EN VENTA DE ACTIVO FIJO');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '4303', 'GASTOS POR IMPUESTOS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Debe', '4304', 'Otros gastos');




Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '5', 'CUENTAS DE RESULTADO ACREEDORAS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '51', 'INGRESOS DE OPERACION');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '5101', 'VENTAS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '5102', 'REBAJAS Y DEVOLUCIONES SOBRE COMPRAS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '5103', 'DESCUENTOS SOBRE COMPRAS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '52', 'INGRESOS DE NO OPERACION');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '5201', 'INTERESES');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '5202', 'UTILIDAD EN VENTA DE ACTIVO FIJO');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '5203', 'OTROS INGRESOS');
Insert into catalogo_cuenta(naturaleza, codigo, cuenta) values ('Haber', '5204', 'INGRESO POR IMPUESTO DE RENTA DIFERIDO');