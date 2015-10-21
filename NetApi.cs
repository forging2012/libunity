// Code generated by gen_proto.sh.
// DO NOT EDIT!
using UnityEngine;
using System;
using System.Collections.Generic;

namespace NetProto.Api
{
    public enum ENetMsgId
    { 
        heart_beat_req = 0, // 心跳包..
        heart_beat_ack = 1, // 心跳包回复
        user_login_req = 10, // 登陆
        user_login_succeed_ack = 11, // 登陆成功
        user_login_faild_ack = 12, // 登陆失败
        client_error_ack = 13, // 客户端错误
        get_seed_req = 30, // socket通信加密使用
        get_seed_ack = 31, // socket通信加密使用
        proto_ping_req = 1001, //  ping
        proto_ping_ack = 1002, //  ping回复
    };
}
