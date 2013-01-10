/****************************************************
 *  Interface1.h                                         
 *  Created on: 12-Dez-2012 21:25:19                      
 *  Implementation of the Interface Interface1       
 *  Original author: Günther                     
 ****************************************************/

#if !defined(EA_92922720_CE0A_4a08_BDF9_8E8246CAE85D__INCLUDED_)
#define EA_92922720_CE0A_4a08_BDF9_8E8246CAE85D__INCLUDED_


#include <ea_common_defs.h>



/* Interface struct forward declarations */
struct Interface1;

/* Function pointer declarations */
typedef int (*Interface1_CallbackFunc) ( Interface1*);

/* Interface function pointer types */
typedef void (*Func1Ptr)(Interface1*, int, char*);
typedef int (*Func2Ptr)(Interface1*, char*);
typedef int (*Func3Ptr)(Interface1*, Interface1_CallbackFunc);

typedef struct
{
	Func1Ptr func1;
	Func2Ptr func2;
	Func3Ptr func3;
	void* instance;
}  Interface1;



extern void func1(Interface1* p1, int p2, char* p3) = 0;
extern int func2(Interface1* p1, char* p2) = 0;
extern int func3(Interface1* p1, Interface1_CallbackFunc p2) = 0;


#endif /*!defined(EA_92922720_CE0A_4a08_BDF9_8E8246CAE85D__INCLUDED_)*/
 

