/****************************************************
 *  Class1.c                                         
 *  Created on: 16-Nov-2012 20:05:58                      
 *  Implementation of the Class Class1       
 *  Original author: makulik                     
 ****************************************************/

#include "Class1.h"
#include <stddef.h>

int priv_attr1;

#if defined(TAG_A)
/**
 * Has an <b>'ifdef'</b> tagged value with this content: #if defined(TAG_A)
 */
int priv_attr3;
#endif

int priv_attr2;



Class1* newClass1()
{
	return  NULL;
}

int deleteClass1(Class1* this)
{
	return 0;
}

int pub_func1(Class1* this)
{
	return 0;
}

int pub_func2(Class1* this)
{
	return 0;
}

#ifdef TAG_C
/**
 * Has an 'ifdef' tagged value with this content: #ifdef TAG_C
 */
int pub_func3(Class1* this)
{
	return 0;
}
#endif 

