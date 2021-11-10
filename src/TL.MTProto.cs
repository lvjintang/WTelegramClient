﻿// This file is generated automatically
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TL
{
	using BinaryWriter = System.IO.BinaryWriter;
	using Client = WTelegram.Client;

	[TLDef(0x05162463)] //resPQ#05162463 nonce:int128 server_nonce:int128 pq:bytes server_public_key_fingerprints:Vector<long> = ResPQ
	public partial class ResPQ : IObject
	{
		public Int128 nonce;
		public Int128 server_nonce;
		public byte[] pq;
		public long[] server_public_key_fingerprints;
	}

	[TLDef(0x83C95AEC)] //p_q_inner_data#83c95aec pq:bytes p:bytes q:bytes nonce:int128 server_nonce:int128 new_nonce:int256 = P_Q_inner_data
	public partial class PQInnerData : IObject
	{
		public byte[] pq;
		public byte[] p;
		public byte[] q;
		public Int128 nonce;
		public Int128 server_nonce;
		public Int256 new_nonce;
	}
	[TLDef(0xA9F55F95, inheritBefore = true)] //p_q_inner_data_dc#a9f55f95 pq:bytes p:bytes q:bytes nonce:int128 server_nonce:int128 new_nonce:int256 dc:int = P_Q_inner_data
	public partial class PQInnerDataDc : PQInnerData
	{
		public int dc;
	}
	[TLDef(0x3C6A84D4, inheritBefore = true)] //p_q_inner_data_temp#3c6a84d4 pq:bytes p:bytes q:bytes nonce:int128 server_nonce:int128 new_nonce:int256 expires_in:int = P_Q_inner_data
	public partial class PQInnerDataTemp : PQInnerData
	{
		public int expires_in;
	}
	[TLDef(0x56FDDF88, inheritBefore = true)] //p_q_inner_data_temp_dc#56fddf88 pq:bytes p:bytes q:bytes nonce:int128 server_nonce:int128 new_nonce:int256 dc:int expires_in:int = P_Q_inner_data
	public partial class PQInnerDataTempDc : PQInnerData
	{
		public int dc;
		public int expires_in;
	}

	[TLDef(0x75A3F765)] //bind_auth_key_inner#75a3f765 nonce:long temp_auth_key_id:long perm_auth_key_id:long temp_session_id:long expires_at:int = BindAuthKeyInner
	public partial class BindAuthKeyInner : IObject
	{
		public long nonce;
		public long temp_auth_key_id;
		public long perm_auth_key_id;
		public long temp_session_id;
		public DateTime expires_at;
	}

	public abstract partial class ServerDHParams : IObject
	{
		public Int128 nonce;
		public Int128 server_nonce;
	}
	[TLDef(0x79CB045D, inheritBefore = true)] //server_DH_params_fail#79cb045d nonce:int128 server_nonce:int128 new_nonce_hash:int128 = Server_DH_Params
	public partial class ServerDHParamsFail : ServerDHParams
	{
		public Int128 new_nonce_hash;
	}
	[TLDef(0xD0E8075C, inheritBefore = true)] //server_DH_params_ok#d0e8075c nonce:int128 server_nonce:int128 encrypted_answer:bytes = Server_DH_Params
	public partial class ServerDHParamsOk : ServerDHParams
	{
		public byte[] encrypted_answer;
	}

	[TLDef(0xB5890DBA)] //server_DH_inner_data#b5890dba nonce:int128 server_nonce:int128 g:int dh_prime:bytes g_a:bytes server_time:int = Server_DH_inner_data
	public partial class ServerDHInnerData : IObject
	{
		public Int128 nonce;
		public Int128 server_nonce;
		public int g;
		public byte[] dh_prime;
		public byte[] g_a;
		public DateTime server_time;
	}

	[TLDef(0x6643B654)] //client_DH_inner_data#6643b654 nonce:int128 server_nonce:int128 retry_id:long g_b:bytes = Client_DH_Inner_Data
	public partial class ClientDHInnerData : IObject
	{
		public Int128 nonce;
		public Int128 server_nonce;
		public long retry_id;
		public byte[] g_b;
	}

	public abstract partial class SetClientDHParamsAnswer : IObject
	{
		public Int128 nonce;
		public Int128 server_nonce;
	}
	[TLDef(0x3BCBF734, inheritBefore = true)] //dh_gen_ok#3bcbf734 nonce:int128 server_nonce:int128 new_nonce_hash1:int128 = Set_client_DH_params_answer
	public partial class DhGenOk : SetClientDHParamsAnswer
	{
		public Int128 new_nonce_hash1;
	}
	[TLDef(0x46DC1FB9, inheritBefore = true)] //dh_gen_retry#46dc1fb9 nonce:int128 server_nonce:int128 new_nonce_hash2:int128 = Set_client_DH_params_answer
	public partial class DhGenRetry : SetClientDHParamsAnswer
	{
		public Int128 new_nonce_hash2;
	}
	[TLDef(0xA69DAE02, inheritBefore = true)] //dh_gen_fail#a69dae02 nonce:int128 server_nonce:int128 new_nonce_hash3:int128 = Set_client_DH_params_answer
	public partial class DhGenFail : SetClientDHParamsAnswer
	{
		public Int128 new_nonce_hash3;
	}

	public enum DestroyAuthKeyRes : uint
	{
		///<summary>See <a href="https://corefork.telegram.org/constructor/destroy_auth_key_ok"/></summary>
		Ok = 0xF660E1D4,
		///<summary>See <a href="https://corefork.telegram.org/constructor/destroy_auth_key_none"/></summary>
		None = 0x0A9F2259,
		///<summary>See <a href="https://corefork.telegram.org/constructor/destroy_auth_key_fail"/></summary>
		Fail = 0xEA109B13,
	}

	[TLDef(0x62D6B459)] //msgs_ack#62d6b459 msg_ids:Vector<long> = MsgsAck
	public partial class MsgsAck : IObject
	{
		public long[] msg_ids;
	}

	[TLDef(0xA7EFF811)] //bad_msg_notification#a7eff811 bad_msg_id:long bad_msg_seqno:int error_code:int = BadMsgNotification
	public partial class BadMsgNotification : IObject
	{
		public long bad_msg_id;
		public int bad_msg_seqno;
		public int error_code;
	}
	[TLDef(0xEDAB447B, inheritBefore = true)] //bad_server_salt#edab447b bad_msg_id:long bad_msg_seqno:int error_code:int new_server_salt:long = BadMsgNotification
	public partial class BadServerSalt : BadMsgNotification
	{
		public long new_server_salt;
	}

	[TLDef(0xDA69FB52)] //msgs_state_req#da69fb52 msg_ids:Vector<long> = MsgsStateReq
	public partial class MsgsStateReq : IObject
	{
		public long[] msg_ids;
	}

	[TLDef(0x04DEB57D)] //msgs_state_info#04deb57d req_msg_id:long info:bytes = MsgsStateInfo
	public partial class MsgsStateInfo : IObject
	{
		public long req_msg_id;
		public byte[] info;
	}

	[TLDef(0x8CC0D131)] //msgs_all_info#8cc0d131 msg_ids:Vector<long> info:bytes = MsgsAllInfo
	public partial class MsgsAllInfo : IObject
	{
		public long[] msg_ids;
		public byte[] info;
	}

	public abstract partial class MsgDetailedInfoBase : IObject
	{
		public abstract long AnswerMsgId { get; }
		public abstract int Bytes { get; }
		public abstract int Status { get; }
	}
	[TLDef(0x276D3EC6)] //msg_detailed_info#276d3ec6 msg_id:long answer_msg_id:long bytes:int status:int = MsgDetailedInfo
	public partial class MsgDetailedInfo : MsgDetailedInfoBase
	{
		public long msg_id;
		public long answer_msg_id;
		public int bytes;
		public int status;

		public override long AnswerMsgId => answer_msg_id;
		public override int Bytes => bytes;
		public override int Status => status;
	}
	[TLDef(0x809DB6DF)] //msg_new_detailed_info#809db6df answer_msg_id:long bytes:int status:int = MsgDetailedInfo
	public partial class MsgNewDetailedInfo : MsgDetailedInfoBase
	{
		public long answer_msg_id;
		public int bytes;
		public int status;

		public override long AnswerMsgId => answer_msg_id;
		public override int Bytes => bytes;
		public override int Status => status;
	}

	[TLDef(0x7D861A08)] //msg_resend_req#7d861a08 msg_ids:Vector<long> = MsgResendReq
	public partial class MsgResendReq : IObject
	{
		public long[] msg_ids;
	}

	[TLDef(0x2144CA19)] //rpc_error#2144ca19 error_code:int error_message:string = RpcError
	public partial class RpcError : IObject
	{
		public int error_code;
		public string error_message;
	}

	public abstract partial class RpcDropAnswer : IObject { }
	[TLDef(0x5E2AD36E)] //rpc_answer_unknown#5e2ad36e = RpcDropAnswer
	public partial class RpcAnswerUnknown : RpcDropAnswer { }
	[TLDef(0xCD78E586)] //rpc_answer_dropped_running#cd78e586 = RpcDropAnswer
	public partial class RpcAnswerDroppedRunning : RpcDropAnswer { }
	[TLDef(0xA43AD8B7)] //rpc_answer_dropped#a43ad8b7 msg_id:long seq_no:int bytes:int = RpcDropAnswer
	public partial class RpcAnswerDropped : RpcDropAnswer
	{
		public long msg_id;
		public int seq_no;
		public int bytes;
	}

	[TLDef(0x0949D9DC)] //future_salt#0949d9dc valid_since:int valid_until:int salt:long = FutureSalt
	public partial class FutureSalt : IObject
	{
		public DateTime valid_since;
		public DateTime valid_until;
		public long salt;
	}

	[TLDef(0xAE500895)] //future_salts#ae500895 req_msg_id:long now:int salts:vector<future_salt> = FutureSalts
	public partial class FutureSalts : IObject
	{
		public long req_msg_id;
		public DateTime now;
		public FutureSalt[] salts;
	}

	[TLDef(0x347773C5)] //pong#347773c5 msg_id:long ping_id:long = Pong
	public partial class Pong : IObject
	{
		public long msg_id;
		public long ping_id;
	}

	public abstract partial class DestroySessionRes : IObject
	{
		public long session_id;
	}
	[TLDef(0xE22045FC)] //destroy_session_ok#e22045fc session_id:long = DestroySessionRes
	public partial class DestroySessionOk : DestroySessionRes { }
	[TLDef(0x62D350C9)] //destroy_session_none#62d350c9 session_id:long = DestroySessionRes
	public partial class DestroySessionNone : DestroySessionRes { }

	public abstract partial class NewSession : IObject { }
	[TLDef(0x9EC20908)] //new_session_created#9ec20908 first_msg_id:long unique_id:long server_salt:long = NewSession
	public partial class NewSessionCreated : NewSession
	{
		public long first_msg_id;
		public long unique_id;
		public long server_salt;
	}

	[TLDef(0x9299359F)] //http_wait#9299359f max_delay:int wait_after:int max_wait:int = HttpWait
	public partial class HttpWait : IObject
	{
		public int max_delay;
		public int wait_after;
		public int max_wait;
	}

	[TLDef(0xD433AD73)] //ipPort#d433ad73 ipv4:int port:int = IpPort
	public partial class IpPort : IObject
	{
		public int ipv4;
		public int port;
	}
	[TLDef(0x37982646, inheritBefore = true)] //ipPortSecret#37982646 ipv4:int port:int secret:bytes = IpPort
	public partial class IpPortSecret : IpPort
	{
		public byte[] secret;
	}

	[TLDef(0x4679B65F)] //accessPointRule#4679b65f phone_prefix_rules:bytes dc_id:int ips:vector<IpPort> = AccessPointRule
	public partial class AccessPointRule : IObject
	{
		public byte[] phone_prefix_rules;
		public int dc_id;
		public IpPort[] ips;
	}

	[TLDef(0x5A592A6C)] //help.configSimple#5a592a6c date:int expires:int rules:vector<AccessPointRule> = help.ConfigSimple
	public partial class Help_ConfigSimple : IObject
	{
		public DateTime date;
		public DateTime expires;
		public AccessPointRule[] rules;
	}

	// ---functions---
	#pragma warning disable IDE1006

	public static class MTProto
	{
		[TLDef(0x60469778)]
		public record ReqPq_(Int128 nonce) : IMethod<ResPQ>;
		public static Task<ResPQ> ReqPq(this Client client, Int128 nonce)
			=> client.CallBareAsync(new ReqPq_(nonce));

		[TLDef(0xBE7E8EF1)]
		public record ReqPqMulti_(Int128 nonce) : IMethod<ResPQ>;
		public static Task<ResPQ> ReqPqMulti(this Client client, Int128 nonce)
			=> client.CallBareAsync(new ReqPqMulti_(nonce));

		[TLDef(0xD712E4BE)]
		public record ReqDHParams_(Int128 nonce, Int128 server_nonce, byte[] p, byte[] q, long public_key_fingerprint, byte[] encrypted_data) : IMethod<ServerDHParams>;
		public static Task<ServerDHParams> ReqDHParams(this Client client, Int128 nonce, Int128 server_nonce, byte[] p, byte[] q, long public_key_fingerprint, byte[] encrypted_data)
			=> client.CallBareAsync(new ReqDHParams_(nonce, server_nonce, p, q, public_key_fingerprint, encrypted_data));

		[TLDef(0xF5045F1F)]
		public record SetClientDHParams_(Int128 nonce, Int128 server_nonce, byte[] encrypted_data) : IMethod<SetClientDHParamsAnswer>;
		public static Task<SetClientDHParamsAnswer> SetClientDHParams(this Client client, Int128 nonce, Int128 server_nonce, byte[] encrypted_data)
			=> client.CallBareAsync(new SetClientDHParams_(nonce, server_nonce, encrypted_data));

		[TLDef(0xD1435160)]
		public record DestroyAuthKey_() : IMethod<DestroyAuthKeyRes>;
		public static Task<DestroyAuthKeyRes> DestroyAuthKey(this Client client)
			=> client.CallBareAsync(new DestroyAuthKey_());

		[TLDef(0x58E4A740)]
		public record RpcDropAnswer_(long req_msg_id) : IMethod<RpcDropAnswer>;
		public static Task<RpcDropAnswer> RpcDropAnswer(this Client client, long req_msg_id)
			=> client.CallBareAsync(new RpcDropAnswer_(req_msg_id));

		[TLDef(0xB921BD04)]
		public record GetFutureSalts_(int num) : IMethod<FutureSalts>;
		public static Task<FutureSalts> GetFutureSalts(this Client client, int num)
			=> client.CallAsync(new GetFutureSalts_(num));

		[TLDef(0x7ABE77EC)]
		public record Ping_(long ping_id) : IMethod<Pong>;
		public static Task<Pong> Ping(this Client client, long ping_id)
			=> client.CallAsync(new Ping_(ping_id));

		[TLDef(0xF3427B8C)]
		public record PingDelayDisconnect_(long ping_id, int disconnect_delay) : IMethod<Pong>;
		public static Task<Pong> PingDelayDisconnect(this Client client, long ping_id, int disconnect_delay)
			=> client.CallAsync(new PingDelayDisconnect_(ping_id, disconnect_delay));

		[TLDef(0xE7512126)]
		public record DestroySession_(long session_id) : IMethod<DestroySessionRes>;
		public static Task<DestroySessionRes> DestroySession(this Client client, long session_id)
			=> client.CallBareAsync(new DestroySession_(session_id));
	}
}
