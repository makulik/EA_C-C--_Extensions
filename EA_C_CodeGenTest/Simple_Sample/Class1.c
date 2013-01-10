/****************************************************
 *  Class1.c                                         
 *  Created on: 28-Nov-2012 00:24:56                      
 *  Implementation of the Class Class1       
 *  Original author: makulik                     
 ****************************************************/

#include "Class1.h"
#include <stddef.h>



EA_pub_static_definition(int,pub_stat_attr1);


extern int priv_extern_attr;


static int priv_attr1;
static int priv_attr2;


static int class1_priv_func1(Class1* this);
static int class1_stat_func1();



Class1* newClass1()
{
	return  NULL;
}

int deleteClass1(Class1* this)
{
	return 0;
}

int class1_pub_func1(Class1* this)
{
	return 0;
}

int class1_pub_func2(Class1* this)
{
	return 0;
}

int class1_prot_func1(Class1* this)
{
	return 0;
}

static int class1_priv_func1(Class1* this)
{
	return 0;
}

static int class1_stat_func1()
{
	return 0;
} 

