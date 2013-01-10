/****************************************************
 *  Class1.h                                         
 *  Created on: 28-Nov-2012 00:24:55                      
 *  Implementation of the Class Class1       
 *  Original author: makulik                     
 ****************************************************/

#if !defined(EA_9D38662D_D01F_4fdc_AE3B_9867EA8D4FF8__INCLUDED_)
#define EA_9D38662D_D01F_4fdc_AE3B_9867EA8D4FF8__INCLUDED_


#include <stdint.h>

#include "Class2.h"



typedef struct
{
	int pub_attr1;
	int pub_attr2;
	uint16_t pub_attr3;
	Class2* m_Class2;
}  Class1;

#define def_attr1 42
extern int pub_stat_attr1;


Class1* newClass1();
int deleteClass1(Class1* this);
int class1_pub_func1(Class1* this);
int class1_pub_func2(Class1* this);
#define class1_Macro(a, b) 
int class1_prot_func1(Class1* this);


#endif /*!defined(EA_9D38662D_D01F_4fdc_AE3B_9867EA8D4FF8__INCLUDED_)*/
 