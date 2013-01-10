/****************************************************
 *  Interface1.h                                         
 *  Created on: 11-Dez-2012 21:43:10                      
 *  Implementation of the Interface Interface1       
 *  Original author: Günther                     
 ****************************************************/

#if !defined(EA_FC8DA485_95EA_4ef3_A3BB_543E93EDE81A__INCLUDED_)
#define EA_FC8DA485_95EA_4ef3_A3BB_543E93EDE81A__INCLUDED_


#include <ea_common_defs.h>



/* Interface struct forward declarations */
struct Interface1;

/* Function pointer declarations */
typedef int (*CallbackFunc) ( Interface1*);

/* Interface function pointer types */
typedef void (*Func1Ptr)(Interface1*, int, char*);
typedef int (*Func2Ptr)(Interface1*, char*);
typedef int (*Func3Ptr)(Interface1*, int(*)(Interface1*));

typedef struct
{
	Func1Ptr func1;
	Func2Ptr func2;
	Func3Ptr func3;
	void* instance;
}  Interface1;

/* The following extern declarations are only dummies to satisfy code reverse engineering,
 * and never should be called.
 */
extern void func1(Interface1* p1, int p2, char* p3) = 0;
extern int func2(Interface1* p1, char* p2) = 0;
extern int func3(Interface1* p1, int(*p2)(Interface1*)) = 0;


#endif /*!defined(EA_FC8DA485_95EA_4ef3_A3BB_543E93EDE81A__INCLUDED_)*/
 