/****************************************************
 *  Class1.h                                         
 *  Created on: 11-Dez-2012 21:43:10                      
 *  Implementation of the Class Class1       
 *  Original author: Günther                     
 ****************************************************/

#if !defined(EA_FAFEC8C8_32CC_4c65_80DA_92760B39FCDF__INCLUDED_)
#define EA_FAFEC8C8_32CC_4c65_80DA_92760B39FCDF__INCLUDED_


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
int Class1_func3(struct Interface1* self, int(*p1)(Interface1*));
int Class1_func4(void (*p1)(Class1*));


#endif /*!defined(EA_FAFEC8C8_32CC_4c65_80DA_92760B39FCDF__INCLUDED_)*/
 