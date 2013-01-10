/*
 * ea_common_defs.h
 *
 *  Created on: 21.11.2012
 *      Author: Admin
 */

#ifndef EA_COMMON_DEFS_H_
#define EA_COMMON_DEFS_H_

#if !defined(EA_extern)
#define EA_extern extern
#endif

#if !defined(EA_pub_static_definition)
#define EA_pub_static_definition(type,name) type name
#endif

#if !defined(EA_pub_static_definition_init)
#define EA_pub_static_definition_init(type,name,initial) type name = initial
#endif

#if !defined(EA_static)
#define EA_static static
#endif

#if !defined(EA_func_ptr_definition)
#define EA_func_ptr_definition(ret_type,typename,sig) typedef ret_type (*typename)sig
#endif

#endif /* EA_COMMON_DEFS_H_ */
