/****************************************************
 *  Class2.h                                         
 *  Created on: 17-Nov-2012 18:11:07                      
 *  Implementation of the Class Class2       
 *  Original author: Günther                     
 ****************************************************/

#if !defined(EA_19481507_7D8D_4850_975B_113116275535__INCLUDED_)
#define EA_19481507_7D8D_4850_975B_113116275535__INCLUDED_


#include <stdint.h>

typedef struct
{
	uint8_t pub_attr1;
}  Class2;

Class2* newClass2();
int deleteClass2(Class2* this);
int C2_pub_func1(Class2* this);
int class2_pub_func1(Class2* this);


#endif /*!defined(EA_19481507_7D8D_4850_975B_113116275535__INCLUDED_)*/
 