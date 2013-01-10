/****************************************************
 *  Class2.c                                         
 *  Created on: 10-Jan-2013 21:14:01                      
 *  Implementation of the Class Class2       
 *  Original author: Günther                     
 ****************************************************/

#include "Class2.h"

/**
 * Imported (static) attribute
 */


EA_pub_static_definition(int,pub_extern_attr1);
EA_pub_static_definition_init(int,pub_extern_attr2, = 42);


extern int priv_extern_attr1;


/**
 * Imported (static) attribute
 */
/**
 * Private attribute
 */
int priv_attr1;
/**
 * Initialized private attribute
 */
int priv_attr2 = 17;


/**
 * Private imported function
 */
extern void priv_extern_func1();
/**
 * Private function
 */
static void class2_priv_func1();



/**
 * Exported function
 */
void class2_pub_func1()
{
	
}

/**
 * Private function
 */
static void class2_priv_func1()
{
	
} 

