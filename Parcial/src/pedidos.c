/*
 * pedidos.c
 *
 *  Created on: 10 oct. 2019
 *      Author: alumno
 */

#include <stdio.h>
#include <stdio_ext.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

#include "validaciones.h"
#include "clientes.h"
#include "pedidos.h"

int inicializar_Pedido(ePedido* list, int len)
{
    int i;
    int retorno=-1;
    if(list!=NULL && len>0)
    {
        for(i=0;i<len;i++)
        {
            list[i].isEmpty = TRUE;
        }
        retorno=0;
    }
    return retorno;
}

/*int hardcodear_Pedido(ePedido* list)
{
	ePedido auxlist[]=
    {
       {1, "Juan", "Gonzales", 23, 1, 2, FALSE},
       {2, "Pedro", "Picapiedra", 60, 2, 1, FALSE},
       {3, "Mario", "Bros", 50, 3, 3, FALSE},
       {4, "Luigi", "Nobros", 48, 6, 4, FALSE},
       {5, "Pepe", "Sapo", 10, 1, 3, FALSE},
       {6, "Jorge", "Alfajor", 15, 5, 1, FALSE},
    };

    for(int i=0; i<6; i++)
    {
        if(auxlist[i].isEmpty==FALSE)
            list[i] = auxlist[i];
    }
    return 0;
}*/

int buscarIndexVacio_Pedido(ePedido* list, int len)
{
    int retorno=-1;
    int index;
    if(list!=NULL && len>0)
    {
        for(index=0;index<len;index++)
        {
            if(list[index].isEmpty==TRUE)
            {
                retorno = index;
                break;
            }
        }
    }
    return retorno;
}


int alta_Pedido(ePedido* list, int len, int id, eCliente* arrayCliente, int lenCliente)
{
    int retorno=-1;
    int index;
    int idCliente;
    ePedido auxList;

    index = buscarIndexVacio_Pedido(list, len);
    if(list!=NULL && index>=0 && index<len)
    {
    	listar_Cliente(arrayCliente, lenCliente);
    	getNumInt(&idCliente, 3, 1, 10000,"\nIngrese el ID de Cliente: ", "Error\n");
    	if(buscar_ClienteById(arrayCliente, idCliente, TAM_CLIENTE)!=-1
    	&& getNumInt(&auxList.kilos, 3, 0, 50000, "\nIngrese la cantidad de residuo en kilos: ", "\nError")==0)
    	{
    		list[index] = auxList;
    		list[index].id = id;
    		list[index].idCliente = idCliente;
    		list[index].estado = PENDIENTE;
    		list[index].isEmpty = FALSE;
    		retorno = 0;
    	}
    }
    else
    {
        printf("\n\nNo hay mas espacio para guardar Clientes");
    }
    return retorno;
}


int buscar_PedidoById(ePedido* list, int id, int len)
{
    int i;
    int retorno=-1;
    for(i=0; i<len; i++)
    {
        if(list[i].isEmpty==FALSE && list[i].id==id)
        {
            retorno=i;
            break;
        }
    }
    if(retorno==-1)
    {
        printf("No se encontro el ID\n");
    }
    return retorno;
}

int print_PedidoPendiente(ePedido* list, int index, int len, eCliente* arrayCliente, int lenCliente)
{
    int retorno=-1;
    int indexCliente;

    indexCliente = buscar_ClienteById(arrayCliente, list[index].idCliente, lenCliente);
    if(list!=NULL && index<len)
    {
    	printf("%d\t%s\t%s\t\t%d\n",list[index].id, arrayCliente[indexCliente].cuit, arrayCliente[indexCliente].direccion, list[index].kilos);
        retorno=0;
    }
    else
    {
        printf("Error al imprimir los datos del musico \n");
    }
    return retorno;
}

void listar_PedidoPendiente(ePedido* list, int len, eCliente* arrayCliente, int lenCliente)
{
    int i;

    printf("\n\nID\tCUIT\tDIRECCION\t\tKILOS\n");
    for(i=0;i<len;i++)
    {
        if(list[i].isEmpty==FALSE && list[i].estado==PENDIENTE)
        {
            print_PedidoPendiente(list,i,len, arrayCliente, lenCliente);
        }
    }
}


int procesarResiduos(ePedido* list, int len, eCliente* arrayCliente, int lenCliente)
{
	int retorno=-1;
	int idPedido;
	int indexPedido;
	float hdpeKilos;
	float ldpeKilos;
	float ppKilos;
	float kilosMaximo;


	listar_PedidoPendiente(list, len, arrayCliente, lenCliente);
	if(getNumInt(&idPedido, 3, 0, 2000, "\nIngrese el ID del pedido: ", "\nError")==0)
	{
		indexPedido = buscar_PedidoById(list, idPedido, len);
		if(indexPedido!=-1)
		{
			kilosMaximo = list[indexPedido].kilos;

			if(getNumFloat(&hdpeKilos, 3, 0, kilosMaximo, "\nIngrese la cantidad de HDPE en kilos: ", "\nError")==0)
			{
				kilosMaximo = kilosMaximo - hdpeKilos;
			}

			if(getNumFloat(&ldpeKilos, 3, 0, kilosMaximo, "\nIngrese la cantidad de LDPE en kilos: ", "\nError")==0)
			{
				kilosMaximo = kilosMaximo - ldpeKilos;
			}
			if(getNumFloat(&ppKilos, 3, 0, kilosMaximo, "\nIngrese la cantidad de PP en kilos: ", "\nError")==0)
			{
				kilosMaximo = kilosMaximo - ppKilos;
			}
			if(kilosMaximo<0)
			{
				printf("\nNo puede haber basura en negativo");
			}
			else
			{
				list[indexPedido].hdpe = hdpeKilos;
				list[indexPedido].ldpe = ldpeKilos;
				list[indexPedido].pp = ppKilos;
				list[indexPedido].estado = COMPLETADO;
				retorno = 0;
			}
		}
	}
	return retorno;
}


int print_PedidoProcesado(ePedido* list, int index, int len, eCliente* arrayCliente, int lenCliente)
{
    int retorno=-1;
    int indexCliente;

    indexCliente = buscar_ClienteById(arrayCliente, list[index].idCliente, lenCliente);
    if(list!=NULL && index<len)
    {
    	printf("%d\t%s\t%s\t\t%d\n",list[index].id, arrayCliente[indexCliente].cuit, arrayCliente[indexCliente].direccion, list[index].kilos);
        retorno=0;
    }
    else
    {
        printf("Error al imprimir los datos del musico \n");
    }
    return retorno;
}

void listar_PedidoProcesado(ePedido* list, int len, eCliente* arrayCliente, int lenCliente)
{
    int i;

    printf("\n\nID\tCUIT\tDIRECCION\t\tKILOS\n");
    for(i=0;i<len;i++)
    {
        if(list[i].isEmpty==FALSE && list[i].estado==PENDIENTE)
        {
            print_PedidoPendiente(list,i,len, arrayCliente, lenCliente);
        }
    }
}

/*void cargarDescripcionPedido(int idPedido, char desc[])
{
    switch(idPedido)
    {
        case 1:
            strcpy(desc, "PENDIENTE");
            break;

        case 2:
            strcpy(desc, "COMPLETADO");
            break;
    }
}*/
