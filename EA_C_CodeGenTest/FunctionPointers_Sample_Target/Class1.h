/****************************************************
 *  Class1.h                                         
 *  Created on: 04-Dez-2012 19:43:35                      
 *  Implementation of the Class Class1       
 *  Original author: Günther                     
 ****************************************************/

#if !defined(EA_AF699DE2_CBF5_4282_A6F3_1331208D891C__INCLUDED_)
#define EA_AF699DE2_CBF5_4282_A6F3_1331208D891C__INCLUDED_


#include "Interface1.h"

struct Class1;

typedef  void (*Class1_CallbackFunc)(Class1* class1);

typedef struct
{
	struct Interface1 iface1;
}  Class1;

Class1* Class1_new();
void Class1_delete(Class1* this);
void Class1_func1(struct Interface1* self, int p1, char* p2);
int Class1_func2(struct Interface1* self, char* prm1);
int Class1_func3(struct Interface1* self, CallbackFunc p1);
int Class1_func4(Class1_CallbackFunc p1);

#endif /*!defined(EA_AF699DE2_CBF5_4282_A6F3_1331208D891C__INCLUDED_)*/
 
