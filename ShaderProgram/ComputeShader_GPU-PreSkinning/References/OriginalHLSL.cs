
 // ---- Created with 3Dmigoto v1.3.16 on Fri Aug 16 13:33:27 2024
 struct t2_t {
   float val[16];
 };
 StructuredBuffer<t2_t> t2 : register(t2);

 cbuffer cb0 : register(b0)
 {
   float4 cb0[1];
 }




 // 3Dmigoto declarations
 #define cmp -
 Texture1D<float4> IniParams : register(t120);
 Texture2D<float4> StereoParams : register(t125);


 void main)
 {
 // Needs manual fix for instruction:
 // unknown dcl_: dcl_resource_raw t0
 // Needs manual fix for instruction:
 // unknown dcl_: dcl_resource_raw t1
 // Needs manual fix for instruction:
 // unknown dcl_: dcl_uav_raw u0
   float4 r0,r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,r11,r12,r13,r14;
   uint4 bitmask, uiDest;
   float4 fDest;

 // Needs manual fix for instruction:
 // unknown dcl_: dcl_thread_group 64, 1, 1
   r0.x = cmp((uint)vThreadID.x >= asuint(cb0[0].x));
   if (r0.x != 0) {
     return;
   }
   r0.x = (int)vThreadID.x * 40;
 // No code for instruction (needs manual fix):
 ld_raw_indexable(raw_buffer)(mixed,mixed,mixed,mixed) r1.xyz, r0.x, t0.xyzx
   r0.yz = mad((int2)vThreadID.xx, int2(40,40), int2(12,24));
 // No code for instruction (needs manual fix):
 ld_raw_indexable(raw_buffer)(mixed,mixed,mixed,mixed) r2.xyz, r0.y, t0.xyzx
 // No code for instruction (needs manual fix):
 ld_raw_indexable(raw_buffer)(mixed,mixed,mixed,mixed) r3.xyzw, r0.z, t0.xyzw
   r0.w = (uint)vThreadID.x << 5;
 // No code for instruction (needs manual fix):
 ld_raw_indexable(raw_buffer)(mixed,mixed,mixed,mixed) r4.xyzw, r0.w, t1.xyzw
   r0.w = mad((int)vThreadID.x, 32, 16);
 // No code for instruction (needs manual fix):
 ld_raw_indexable(raw_buffer)(mixed,mixed,mixed,mixed) r5.xyzw, r0.w, t1.xyzw
   r6.x = t2[r5.x].val[0/4];
   r6.y = t2[r5.x].val[0/4+1];
   r6.z = t2[r5.x].val[0/4+2];
   r7.x = t2[r5.x].val[16/4];
   r7.y = t2[r5.x].val[16/4+1];
   r7.z = t2[r5.x].val[16/4+2];
   r8.x = t2[r5.x].val[32/4];
   r8.y = t2[r5.x].val[32/4+1];
   r8.z = t2[r5.x].val[32/4+2];
   r9.x = t2[r5.x].val[48/4];
   r9.y = t2[r5.x].val[48/4+1];
   r9.w = t2[r5.x].val[48/4+2];
   r10.x = r6.x;
   r10.y = r7.x;
   r10.z = r8.x;
   r10.w = r9.x;
   r11.x = r6.y;
   r11.y = r7.y;
   r11.z = r8.y;
   r11.w = r9.y;
   r9.x = r6.z;
   r9.y = r7.z;
   r9.z = r8.z;
   r6.x = t2[r5.y].val[0/4];
   r6.y = t2[r5.y].val[0/4+1];
   r6.z = t2[r5.y].val[0/4+2];
   r7.x = t2[r5.y].val[16/4];
   r7.y = t2[r5.y].val[16/4+1];
   r7.z = t2[r5.y].val[16/4+2];
   r8.x = t2[r5.y].val[32/4];
   r8.y = t2[r5.y].val[32/4+1];
   r8.z = t2[r5.y].val[32/4+2];
   r12.x = t2[r5.y].val[48/4];
   r12.y = t2[r5.y].val[48/4+1];
   r12.w = t2[r5.y].val[48/4+2];
   r13.x = r6.x;
   r13.y = r7.x;
   r13.z = r8.x;
   r13.w = r12.x;
   r13.xyzw = r13.xyzw * r4.yyyy;
   r14.x = r6.y;
   r14.y = r7.y;
   r14.z = r8.y;
   r14.w = r12.y;
   r14.xyzw = r14.xyzw * r4.yyyy;
   r12.x = r6.z;
   r12.y = r7.z;
   r12.z = r8.z;
   r6.xyzw = r12.xyzw * r4.yyyy;
   r7.xyzw = r10.xyzw * r4.xxxx + r13.xyzw;
   r8.xyzw = r11.xyzw * r4.xxxx + r14.xyzw;
   r6.xyzw = r9.xyzw * r4.xxxx + r6.xyzw;
   r9.x = t2[r5.z].val[0/4];
   r9.y = t2[r5.z].val[0/4+1];
   r9.z = t2[r5.z].val[0/4+2];
   r10.x = t2[r5.z].val[16/4];
   r10.y = t2[r5.z].val[16/4+1];
   r10.z = t2[r5.z].val[16/4+2];
   r11.x = t2[r5.z].val[32/4];
   r11.y = t2[r5.z].val[32/4+1];
   r11.z = t2[r5.z].val[32/4+2];
   r12.x = t2[r5.z].val[48/4];
   r12.y = t2[r5.z].val[48/4+1];
   r12.w = t2[r5.z].val[48/4+2];
   r13.x = r9.x;
   r13.y = r10.x;
   r13.z = r11.x;
   r13.w = r12.x;
   r14.x = r9.y;
   r14.y = r10.y;
   r14.z = r11.y;
   r14.w = r12.y;
   r12.x = r9.z;
   r12.y = r10.z;
   r12.z = r11.z;
   r7.xyzw = r13.xyzw * r4.zzzz + r7.xyzw;
   r8.xyzw = r14.xyzw * r4.zzzz + r8.xyzw;
   r6.xyzw = r12.xyzw * r4.zzzz + r6.xyzw;
   r4.x = t2[r5.w].val[0/4];
   r4.y = t2[r5.w].val[0/4+1];
   r4.z = t2[r5.w].val[0/4+2];
   r5.x = t2[r5.w].val[16/4];
   r5.y = t2[r5.w].val[16/4+1];
   r5.z = t2[r5.w].val[16/4+2];
   r9.x = t2[r5.w].val[32/4];
   r9.y = t2[r5.w].val[32/4+1];
   r9.z = t2[r5.w].val[32/4+2];
   r10.x = t2[r5.w].val[48/4];
   r10.y = t2[r5.w].val[48/4+1];
   r10.w = t2[r5.w].val[48/4+2];
   r11.x = r4.x;
   r11.y = r5.x;
   r11.z = r9.x;
   r11.w = r10.x;
   r12.x = r4.y;
   r12.y = r5.y;
   r12.z = r9.y;
   r12.w = r10.y;
   r10.x = r4.z;
   r10.y = r5.z;
   r10.z = r9.z;
   r5.xyzw = r11.xyzw * r4.wwww + r7.xyzw;
   r7.xyzw = r12.xyzw * r4.wwww + r8.xyzw;
   r4.xyzw = r10.xyzw * r4.wwww + r6.xyzw;
   r1.w = 1;
   r6.x = dot(r5.xyzw, r1.xyzw);
   r6.y = dot(r7.xyzw, r1.xyzw);
   r6.z = dot(r4.xyzw, r1.xyzw);
   r1.x = dot(r5.xyz, r2.xyz);
   r1.y = dot(r7.xyz, r2.xyz);
   r1.z = dot(r4.xyz, r2.xyz);
   r2.x = dot(r5.xyz, r3.xyz);
   r2.y = dot(r7.xyz, r3.xyz);
   r2.z = dot(r4.xyz, r3.xyz);
 // No code for instruction (needs manual fix):
 store_raw u0.xyz, r0.x, r6.xyzx
 // No code for instruction (needs manual fix):
 store_raw u0.xyz, r0.y, r1.xyzx
   r2.w = r3.w;
 // No code for instruction (needs manual fix):
 store_raw u0.xyzw, r0.z, r2.xyzw
   return;
 }
