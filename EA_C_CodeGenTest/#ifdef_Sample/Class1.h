/****************************************************
 *  Class1.h                                         
 *  Created on: 16-Nov-2012 20:05:58                      
 *  Implementation of the Class Class1       
 *  Original author: makulik                     
 ****************************************************/

#if !defined(EA_ACAD1BE8_CFC5_426f_9866_FF0972549A48__INCLUDED_)
#define EA_ACAD1BE8_CFC5_426f_9866_FF0972549A48__INCLUDED_


#ifdef __cplusplus
extern "C" {
#endif

typedef struct
{
	int pub_attr1;

	#ifndef TAG_B
	/**
	 * Has an 'ifdef' tagged value with this content: #ifndef TAG_B
	 */
	int pub_attr3;
	#endif

	int pub_attr2;
}  Class1;

Class1* newClass1();
int deleteClass1(Class1* this);
int pub_func1(Class1* this);
int pub_func2(Class1* this);

#ifdef TAG_C

int pub_func3(Class1* this);
#endif


#ifdef __cplusplus
}
#endif


#endif /*!defined(EA_ACAD1BE8_CFC5_426f_9866_FF0972549A48__INCLUDED_)*/
 