/****************************************************
 *  Class1.h                                         
 *  Created on: 12-Dez-2012 21:25:19                      
 *  Implementation of the Class Class1       
 *  Original author: Günther                     
 ****************************************************/

#if !defined(EA_CDC9AA30_1681_44ec_AE7B_09537351CB1D__INCLUDED_)
#define EA_CDC9AA30_1681_44ec_AE7B_09537351CB1D__INCLUDED_


#include <ea_common_defs.h>


#include "Interface1.h"



/* Class struct forward declarations */
struct Class1;

/* Function pointer declarations */
typedef void (*Class1_CallbackFunc) ( Class1*);

typedef struct
{
	struct Interface1 iface1;
}  Class1;



Class1* Class1_new();
void Class1_delete(Class1* this);
void Class1_func1(struct Interface1* self, int p1, char* p2);
int Class1_func2(struct Interface1* self, char* prm1);
int Class1_func3(struct Interface1* self, Interface1_CallbackFunc p1);
int Class1_func4(Class1_CallbackFunc p1);


#endif /*!defined(EA_CDC9AA30_1681_44ec_AE7B_09537351CB1D__INCLUDED_)*/
 