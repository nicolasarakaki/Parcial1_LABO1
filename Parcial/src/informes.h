/*
 * informes.h
 *
 *  Created on: 16 oct. 2019
 *      Author: alumno
 */

#ifndef INFORMES_H_
#define INFORMES_H_

#include "pedidos.h"
#include "clientes.h"

#define TRUE 1
#define FALSE 0



int menuInformes(int reintentos, int numOpcMin, int numOpcMax);

void informar_clienteConMasPendiente(eCliente* arrayCliente, int lenCliente, ePedido* arrayPedido, int lenPedido);

void informar_clienteConMasCompletado(eCliente* arrayCliente, int lenCliente, ePedido* arrayPedido, int lenPedido);

void informar_clienteConMasPedidos(eCliente* arrayCliente, int lenCliente, ePedido* arrayPedido, int lenPedido);

void informar_ClienteMayorKilos(eCliente* arrayCliente, int lenCliente, ePedido* arrayPedido, int lenPedido);

void informar_ClienteMenorKilos(eCliente* arrayCliente, int lenCliente, ePedido* arrayPedido, int lenPedido);

void informar_ClientesMas1000Kilos(eCliente* arrayCliente, int lenCliente, ePedido* arrayPedido, int lenPedido);

void informar_ClientesMenos100Kilos(eCliente* arrayCliente, int lenCliente, ePedido* arrayPedido, int lenPedido);


float calcularPromedioDeKilos(ePedido* arrayPedido, int index);

int informar_UnPedidoProcesado(ePedido* list, int index, int len, eCliente* arrayCliente, int lenCliente);

void informar_PedidoProcesado(ePedido* list, int len, eCliente* arrayCliente, int lenCliente);



void informar_promedioDelTipoPlastico(ePedido* arrayPedido, int lenPedido);

void informar_ClienteDeMayorCantPlastico(eCliente* arrayCliente, int lenCliente, ePedido* arrayPedido, int lenPedido);

#endif /* INFORMES_H_ */
