/****************************************************
 *  Class3.h                                         
 *  Created on: 17-Nov-2012 18:11:07                      
 *  Implementation of the Class Class3       
 *  Original author: Günther                     
 ****************************************************/

#if !defined(EA_147C134F_27AE_4660_B8F0_5362B94B193E__INCLUDED_)
#define EA_147C134F_27AE_4660_B8F0_5362B94B193E__INCLUDED_


#include <stdint.h>

#include "Class1.h"

typedef struct
{
	Class1 *m_Class1;
}  Class3;

Class3* newClass3();
int deleteClass3(Class3* this);
int C3_addClass1(Class3* this, Class1* class1);
int C3_removeClass1(Class3* this, Class1* class1);
int class3_addClass1(Class3* this, Class1* class1);
int class3_removeClass1(Class3* this, Class1* class1);


#endif /*!defined(EA_147C134F_27AE_4660_B8F0_5362B94B193E__INCLUDED_)*/
 