// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: WorldBossRpc.proto

#ifndef PROTOBUF_WorldBossRpc_2eproto__INCLUDED
#define PROTOBUF_WorldBossRpc_2eproto__INCLUDED

#include <string>

#include <google/protobuf/stubs/common.h>

#if GOOGLE_PROTOBUF_VERSION < 2005000
#error This file was generated by a newer version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please update
#error your headers.
#endif
#if 2005000 < GOOGLE_PROTOBUF_MIN_PROTOC_VERSION
#error This file was generated by an older version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please
#error regenerate this file with a newer version of protoc.
#endif

#include <google/protobuf/generated_message_util.h>
#include <google/protobuf/message.h>
#include <google/protobuf/repeated_field.h>
#include <google/protobuf/extension_set.h>
#include <google/protobuf/unknown_field_set.h>
#include "PublicStruct.pb.h"
// @@protoc_insertion_point(includes)

// Internal implementation detail -- do not call these.
void  protobuf_AddDesc_WorldBossRpc_2eproto();
void protobuf_AssignDesc_WorldBossRpc_2eproto();
void protobuf_ShutdownFile_WorldBossRpc_2eproto();

class WorldBossRpcWorldBossInfoAsk;
class WorldBossRpcWorldBossInfoReply;
class WorldBossRpcWorldBossRankInfoAsk;
class WorldBossRpcWorldBossRankInfoReply;

// ===================================================================

class WorldBossRpcWorldBossInfoAsk : public ::google::protobuf::Message {
 public:
  WorldBossRpcWorldBossInfoAsk();
  virtual ~WorldBossRpcWorldBossInfoAsk();

  WorldBossRpcWorldBossInfoAsk(const WorldBossRpcWorldBossInfoAsk& from);

  inline WorldBossRpcWorldBossInfoAsk& operator=(const WorldBossRpcWorldBossInfoAsk& from) {
    CopyFrom(from);
    return *this;
  }

  inline const ::google::protobuf::UnknownFieldSet& unknown_fields() const {
    return _unknown_fields_;
  }

  inline ::google::protobuf::UnknownFieldSet* mutable_unknown_fields() {
    return &_unknown_fields_;
  }

  static const ::google::protobuf::Descriptor* descriptor();
  static const WorldBossRpcWorldBossInfoAsk& default_instance();

  void Swap(WorldBossRpcWorldBossInfoAsk* other);

  // implements Message ----------------------------------------------

  WorldBossRpcWorldBossInfoAsk* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const WorldBossRpcWorldBossInfoAsk& from);
  void MergeFrom(const WorldBossRpcWorldBossInfoAsk& from);
  void Clear();
  bool IsInitialized() const;

  int ByteSize() const;
  bool MergePartialFromCodedStream(
      ::google::protobuf::io::CodedInputStream* input);
  void SerializeWithCachedSizes(
      ::google::protobuf::io::CodedOutputStream* output) const;
  ::google::protobuf::uint8* SerializeWithCachedSizesToArray(::google::protobuf::uint8* output) const;
  int GetCachedSize() const { return _cached_size_; }
  private:
  void SharedCtor();
  void SharedDtor();
  void SetCachedSize(int size) const;
  public:

  ::google::protobuf::Metadata GetMetadata() const;

  // nested types ----------------------------------------------------

  // accessors -------------------------------------------------------

  // optional int32 BossID = 2 [default = -1];
  inline bool has_bossid() const;
  inline void clear_bossid();
  static const int kBossIDFieldNumber = 2;
  inline ::google::protobuf::int32 bossid() const;
  inline void set_bossid(::google::protobuf::int32 value);

  // @@protoc_insertion_point(class_scope:WorldBossRpcWorldBossInfoAsk)
 private:
  inline void set_has_bossid();
  inline void clear_has_bossid();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::int32 bossid_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(1 + 31) / 32];

  friend void  protobuf_AddDesc_WorldBossRpc_2eproto();
  friend void protobuf_AssignDesc_WorldBossRpc_2eproto();
  friend void protobuf_ShutdownFile_WorldBossRpc_2eproto();

  void InitAsDefaultInstance();
  static WorldBossRpcWorldBossInfoAsk* default_instance_;
};
// -------------------------------------------------------------------

class WorldBossRpcWorldBossInfoReply : public ::google::protobuf::Message {
 public:
  WorldBossRpcWorldBossInfoReply();
  virtual ~WorldBossRpcWorldBossInfoReply();

  WorldBossRpcWorldBossInfoReply(const WorldBossRpcWorldBossInfoReply& from);

  inline WorldBossRpcWorldBossInfoReply& operator=(const WorldBossRpcWorldBossInfoReply& from) {
    CopyFrom(from);
    return *this;
  }

  inline const ::google::protobuf::UnknownFieldSet& unknown_fields() const {
    return _unknown_fields_;
  }

  inline ::google::protobuf::UnknownFieldSet* mutable_unknown_fields() {
    return &_unknown_fields_;
  }

  static const ::google::protobuf::Descriptor* descriptor();
  static const WorldBossRpcWorldBossInfoReply& default_instance();

  void Swap(WorldBossRpcWorldBossInfoReply* other);

  // implements Message ----------------------------------------------

  WorldBossRpcWorldBossInfoReply* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const WorldBossRpcWorldBossInfoReply& from);
  void MergeFrom(const WorldBossRpcWorldBossInfoReply& from);
  void Clear();
  bool IsInitialized() const;

  int ByteSize() const;
  bool MergePartialFromCodedStream(
      ::google::protobuf::io::CodedInputStream* input);
  void SerializeWithCachedSizes(
      ::google::protobuf::io::CodedOutputStream* output) const;
  ::google::protobuf::uint8* SerializeWithCachedSizesToArray(::google::protobuf::uint8* output) const;
  int GetCachedSize() const { return _cached_size_; }
  private:
  void SharedCtor();
  void SharedDtor();
  void SetCachedSize(int size) const;
  public:

  ::google::protobuf::Metadata GetMetadata() const;

  // nested types ----------------------------------------------------

  // accessors -------------------------------------------------------

  // optional int32 Result = 1 [default = -1];
  inline bool has_result() const;
  inline void clear_result();
  static const int kResultFieldNumber = 1;
  inline ::google::protobuf::int32 result() const;
  inline void set_result(::google::protobuf::int32 value);

  // repeated .WorldBossInfo WorldBossInfos = 2;
  inline int worldbossinfos_size() const;
  inline void clear_worldbossinfos();
  static const int kWorldBossInfosFieldNumber = 2;
  inline const ::WorldBossInfo& worldbossinfos(int index) const;
  inline ::WorldBossInfo* mutable_worldbossinfos(int index);
  inline ::WorldBossInfo* add_worldbossinfos();
  inline const ::google::protobuf::RepeatedPtrField< ::WorldBossInfo >&
      worldbossinfos() const;
  inline ::google::protobuf::RepeatedPtrField< ::WorldBossInfo >*
      mutable_worldbossinfos();

  // optional int32 BossID = 3 [default = -1];
  inline bool has_bossid() const;
  inline void clear_bossid();
  static const int kBossIDFieldNumber = 3;
  inline ::google::protobuf::int32 bossid() const;
  inline void set_bossid(::google::protobuf::int32 value);

  // @@protoc_insertion_point(class_scope:WorldBossRpcWorldBossInfoReply)
 private:
  inline void set_has_result();
  inline void clear_has_result();
  inline void set_has_bossid();
  inline void clear_has_bossid();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::RepeatedPtrField< ::WorldBossInfo > worldbossinfos_;
  ::google::protobuf::int32 result_;
  ::google::protobuf::int32 bossid_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(3 + 31) / 32];

  friend void  protobuf_AddDesc_WorldBossRpc_2eproto();
  friend void protobuf_AssignDesc_WorldBossRpc_2eproto();
  friend void protobuf_ShutdownFile_WorldBossRpc_2eproto();

  void InitAsDefaultInstance();
  static WorldBossRpcWorldBossInfoReply* default_instance_;
};
// -------------------------------------------------------------------

class WorldBossRpcWorldBossRankInfoAsk : public ::google::protobuf::Message {
 public:
  WorldBossRpcWorldBossRankInfoAsk();
  virtual ~WorldBossRpcWorldBossRankInfoAsk();

  WorldBossRpcWorldBossRankInfoAsk(const WorldBossRpcWorldBossRankInfoAsk& from);

  inline WorldBossRpcWorldBossRankInfoAsk& operator=(const WorldBossRpcWorldBossRankInfoAsk& from) {
    CopyFrom(from);
    return *this;
  }

  inline const ::google::protobuf::UnknownFieldSet& unknown_fields() const {
    return _unknown_fields_;
  }

  inline ::google::protobuf::UnknownFieldSet* mutable_unknown_fields() {
    return &_unknown_fields_;
  }

  static const ::google::protobuf::Descriptor* descriptor();
  static const WorldBossRpcWorldBossRankInfoAsk& default_instance();

  void Swap(WorldBossRpcWorldBossRankInfoAsk* other);

  // implements Message ----------------------------------------------

  WorldBossRpcWorldBossRankInfoAsk* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const WorldBossRpcWorldBossRankInfoAsk& from);
  void MergeFrom(const WorldBossRpcWorldBossRankInfoAsk& from);
  void Clear();
  bool IsInitialized() const;

  int ByteSize() const;
  bool MergePartialFromCodedStream(
      ::google::protobuf::io::CodedInputStream* input);
  void SerializeWithCachedSizes(
      ::google::protobuf::io::CodedOutputStream* output) const;
  ::google::protobuf::uint8* SerializeWithCachedSizesToArray(::google::protobuf::uint8* output) const;
  int GetCachedSize() const { return _cached_size_; }
  private:
  void SharedCtor();
  void SharedDtor();
  void SetCachedSize(int size) const;
  public:

  ::google::protobuf::Metadata GetMetadata() const;

  // nested types ----------------------------------------------------

  // accessors -------------------------------------------------------

  // optional int32 BossID = 1 [default = -1];
  inline bool has_bossid() const;
  inline void clear_bossid();
  static const int kBossIDFieldNumber = 1;
  inline ::google::protobuf::int32 bossid() const;
  inline void set_bossid(::google::protobuf::int32 value);

  // optional int32 Occupation = 2 [default = -1];
  inline bool has_occupation() const;
  inline void clear_occupation();
  static const int kOccupationFieldNumber = 2;
  inline ::google::protobuf::int32 occupation() const;
  inline void set_occupation(::google::protobuf::int32 value);

  // @@protoc_insertion_point(class_scope:WorldBossRpcWorldBossRankInfoAsk)
 private:
  inline void set_has_bossid();
  inline void clear_has_bossid();
  inline void set_has_occupation();
  inline void clear_has_occupation();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::int32 bossid_;
  ::google::protobuf::int32 occupation_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(2 + 31) / 32];

  friend void  protobuf_AddDesc_WorldBossRpc_2eproto();
  friend void protobuf_AssignDesc_WorldBossRpc_2eproto();
  friend void protobuf_ShutdownFile_WorldBossRpc_2eproto();

  void InitAsDefaultInstance();
  static WorldBossRpcWorldBossRankInfoAsk* default_instance_;
};
// -------------------------------------------------------------------

class WorldBossRpcWorldBossRankInfoReply : public ::google::protobuf::Message {
 public:
  WorldBossRpcWorldBossRankInfoReply();
  virtual ~WorldBossRpcWorldBossRankInfoReply();

  WorldBossRpcWorldBossRankInfoReply(const WorldBossRpcWorldBossRankInfoReply& from);

  inline WorldBossRpcWorldBossRankInfoReply& operator=(const WorldBossRpcWorldBossRankInfoReply& from) {
    CopyFrom(from);
    return *this;
  }

  inline const ::google::protobuf::UnknownFieldSet& unknown_fields() const {
    return _unknown_fields_;
  }

  inline ::google::protobuf::UnknownFieldSet* mutable_unknown_fields() {
    return &_unknown_fields_;
  }

  static const ::google::protobuf::Descriptor* descriptor();
  static const WorldBossRpcWorldBossRankInfoReply& default_instance();

  void Swap(WorldBossRpcWorldBossRankInfoReply* other);

  // implements Message ----------------------------------------------

  WorldBossRpcWorldBossRankInfoReply* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const WorldBossRpcWorldBossRankInfoReply& from);
  void MergeFrom(const WorldBossRpcWorldBossRankInfoReply& from);
  void Clear();
  bool IsInitialized() const;

  int ByteSize() const;
  bool MergePartialFromCodedStream(
      ::google::protobuf::io::CodedInputStream* input);
  void SerializeWithCachedSizes(
      ::google::protobuf::io::CodedOutputStream* output) const;
  ::google::protobuf::uint8* SerializeWithCachedSizesToArray(::google::protobuf::uint8* output) const;
  int GetCachedSize() const { return _cached_size_; }
  private:
  void SharedCtor();
  void SharedDtor();
  void SetCachedSize(int size) const;
  public:

  ::google::protobuf::Metadata GetMetadata() const;

  // nested types ----------------------------------------------------

  // accessors -------------------------------------------------------

  // optional int32 Result = 1 [default = -1];
  inline bool has_result() const;
  inline void clear_result();
  static const int kResultFieldNumber = 1;
  inline ::google::protobuf::int32 result() const;
  inline void set_result(::google::protobuf::int32 value);

  // repeated .WorldBossRankInfo RankInfo = 2;
  inline int rankinfo_size() const;
  inline void clear_rankinfo();
  static const int kRankInfoFieldNumber = 2;
  inline const ::WorldBossRankInfo& rankinfo(int index) const;
  inline ::WorldBossRankInfo* mutable_rankinfo(int index);
  inline ::WorldBossRankInfo* add_rankinfo();
  inline const ::google::protobuf::RepeatedPtrField< ::WorldBossRankInfo >&
      rankinfo() const;
  inline ::google::protobuf::RepeatedPtrField< ::WorldBossRankInfo >*
      mutable_rankinfo();

  // optional string LastKillName = 3;
  inline bool has_lastkillname() const;
  inline void clear_lastkillname();
  static const int kLastKillNameFieldNumber = 3;
  inline const ::std::string& lastkillname() const;
  inline void set_lastkillname(const ::std::string& value);
  inline void set_lastkillname(const char* value);
  inline void set_lastkillname(const char* value, size_t size);
  inline ::std::string* mutable_lastkillname();
  inline ::std::string* release_lastkillname();
  inline void set_allocated_lastkillname(::std::string* lastkillname);

  // optional string MaxDamageName = 4;
  inline bool has_maxdamagename() const;
  inline void clear_maxdamagename();
  static const int kMaxDamageNameFieldNumber = 4;
  inline const ::std::string& maxdamagename() const;
  inline void set_maxdamagename(const ::std::string& value);
  inline void set_maxdamagename(const char* value);
  inline void set_maxdamagename(const char* value, size_t size);
  inline ::std::string* mutable_maxdamagename();
  inline ::std::string* release_maxdamagename();
  inline void set_allocated_maxdamagename(::std::string* maxdamagename);

  // optional int32 MyRank = 5 [default = -1];
  inline bool has_myrank() const;
  inline void clear_myrank();
  static const int kMyRankFieldNumber = 5;
  inline ::google::protobuf::int32 myrank() const;
  inline void set_myrank(::google::protobuf::int32 value);

  // optional int32 Occupation = 6 [default = -1];
  inline bool has_occupation() const;
  inline void clear_occupation();
  static const int kOccupationFieldNumber = 6;
  inline ::google::protobuf::int32 occupation() const;
  inline void set_occupation(::google::protobuf::int32 value);

  // optional int32 BossID = 7 [default = -1];
  inline bool has_bossid() const;
  inline void clear_bossid();
  static const int kBossIDFieldNumber = 7;
  inline ::google::protobuf::int32 bossid() const;
  inline void set_bossid(::google::protobuf::int32 value);

  // optional int32 MyOccupationRank = 8 [default = -1];
  inline bool has_myoccupationrank() const;
  inline void clear_myoccupationrank();
  static const int kMyOccupationRankFieldNumber = 8;
  inline ::google::protobuf::int32 myoccupationrank() const;
  inline void set_myoccupationrank(::google::protobuf::int32 value);

  // optional int32 MyScore = 9 [default = -1];
  inline bool has_myscore() const;
  inline void clear_myscore();
  static const int kMyScoreFieldNumber = 9;
  inline ::google::protobuf::int32 myscore() const;
  inline void set_myscore(::google::protobuf::int32 value);

  // @@protoc_insertion_point(class_scope:WorldBossRpcWorldBossRankInfoReply)
 private:
  inline void set_has_result();
  inline void clear_has_result();
  inline void set_has_lastkillname();
  inline void clear_has_lastkillname();
  inline void set_has_maxdamagename();
  inline void clear_has_maxdamagename();
  inline void set_has_myrank();
  inline void clear_has_myrank();
  inline void set_has_occupation();
  inline void clear_has_occupation();
  inline void set_has_bossid();
  inline void clear_has_bossid();
  inline void set_has_myoccupationrank();
  inline void clear_has_myoccupationrank();
  inline void set_has_myscore();
  inline void clear_has_myscore();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::RepeatedPtrField< ::WorldBossRankInfo > rankinfo_;
  ::std::string* lastkillname_;
  ::google::protobuf::int32 result_;
  ::google::protobuf::int32 myrank_;
  ::std::string* maxdamagename_;
  ::google::protobuf::int32 occupation_;
  ::google::protobuf::int32 bossid_;
  ::google::protobuf::int32 myoccupationrank_;
  ::google::protobuf::int32 myscore_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(9 + 31) / 32];

  friend void  protobuf_AddDesc_WorldBossRpc_2eproto();
  friend void protobuf_AssignDesc_WorldBossRpc_2eproto();
  friend void protobuf_ShutdownFile_WorldBossRpc_2eproto();

  void InitAsDefaultInstance();
  static WorldBossRpcWorldBossRankInfoReply* default_instance_;
};
// ===================================================================


// ===================================================================

// WorldBossRpcWorldBossInfoAsk

// optional int32 BossID = 2 [default = -1];
inline bool WorldBossRpcWorldBossInfoAsk::has_bossid() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void WorldBossRpcWorldBossInfoAsk::set_has_bossid() {
  _has_bits_[0] |= 0x00000001u;
}
inline void WorldBossRpcWorldBossInfoAsk::clear_has_bossid() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void WorldBossRpcWorldBossInfoAsk::clear_bossid() {
  bossid_ = -1;
  clear_has_bossid();
}
inline ::google::protobuf::int32 WorldBossRpcWorldBossInfoAsk::bossid() const {
  return bossid_;
}
inline void WorldBossRpcWorldBossInfoAsk::set_bossid(::google::protobuf::int32 value) {
  set_has_bossid();
  bossid_ = value;
}

// -------------------------------------------------------------------

// WorldBossRpcWorldBossInfoReply

// optional int32 Result = 1 [default = -1];
inline bool WorldBossRpcWorldBossInfoReply::has_result() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void WorldBossRpcWorldBossInfoReply::set_has_result() {
  _has_bits_[0] |= 0x00000001u;
}
inline void WorldBossRpcWorldBossInfoReply::clear_has_result() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void WorldBossRpcWorldBossInfoReply::clear_result() {
  result_ = -1;
  clear_has_result();
}
inline ::google::protobuf::int32 WorldBossRpcWorldBossInfoReply::result() const {
  return result_;
}
inline void WorldBossRpcWorldBossInfoReply::set_result(::google::protobuf::int32 value) {
  set_has_result();
  result_ = value;
}

// repeated .WorldBossInfo WorldBossInfos = 2;
inline int WorldBossRpcWorldBossInfoReply::worldbossinfos_size() const {
  return worldbossinfos_.size();
}
inline void WorldBossRpcWorldBossInfoReply::clear_worldbossinfos() {
  worldbossinfos_.Clear();
}
inline const ::WorldBossInfo& WorldBossRpcWorldBossInfoReply::worldbossinfos(int index) const {
  return worldbossinfos_.Get(index);
}
inline ::WorldBossInfo* WorldBossRpcWorldBossInfoReply::mutable_worldbossinfos(int index) {
  return worldbossinfos_.Mutable(index);
}
inline ::WorldBossInfo* WorldBossRpcWorldBossInfoReply::add_worldbossinfos() {
  return worldbossinfos_.Add();
}
inline const ::google::protobuf::RepeatedPtrField< ::WorldBossInfo >&
WorldBossRpcWorldBossInfoReply::worldbossinfos() const {
  return worldbossinfos_;
}
inline ::google::protobuf::RepeatedPtrField< ::WorldBossInfo >*
WorldBossRpcWorldBossInfoReply::mutable_worldbossinfos() {
  return &worldbossinfos_;
}

// optional int32 BossID = 3 [default = -1];
inline bool WorldBossRpcWorldBossInfoReply::has_bossid() const {
  return (_has_bits_[0] & 0x00000004u) != 0;
}
inline void WorldBossRpcWorldBossInfoReply::set_has_bossid() {
  _has_bits_[0] |= 0x00000004u;
}
inline void WorldBossRpcWorldBossInfoReply::clear_has_bossid() {
  _has_bits_[0] &= ~0x00000004u;
}
inline void WorldBossRpcWorldBossInfoReply::clear_bossid() {
  bossid_ = -1;
  clear_has_bossid();
}
inline ::google::protobuf::int32 WorldBossRpcWorldBossInfoReply::bossid() const {
  return bossid_;
}
inline void WorldBossRpcWorldBossInfoReply::set_bossid(::google::protobuf::int32 value) {
  set_has_bossid();
  bossid_ = value;
}

// -------------------------------------------------------------------

// WorldBossRpcWorldBossRankInfoAsk

// optional int32 BossID = 1 [default = -1];
inline bool WorldBossRpcWorldBossRankInfoAsk::has_bossid() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void WorldBossRpcWorldBossRankInfoAsk::set_has_bossid() {
  _has_bits_[0] |= 0x00000001u;
}
inline void WorldBossRpcWorldBossRankInfoAsk::clear_has_bossid() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void WorldBossRpcWorldBossRankInfoAsk::clear_bossid() {
  bossid_ = -1;
  clear_has_bossid();
}
inline ::google::protobuf::int32 WorldBossRpcWorldBossRankInfoAsk::bossid() const {
  return bossid_;
}
inline void WorldBossRpcWorldBossRankInfoAsk::set_bossid(::google::protobuf::int32 value) {
  set_has_bossid();
  bossid_ = value;
}

// optional int32 Occupation = 2 [default = -1];
inline bool WorldBossRpcWorldBossRankInfoAsk::has_occupation() const {
  return (_has_bits_[0] & 0x00000002u) != 0;
}
inline void WorldBossRpcWorldBossRankInfoAsk::set_has_occupation() {
  _has_bits_[0] |= 0x00000002u;
}
inline void WorldBossRpcWorldBossRankInfoAsk::clear_has_occupation() {
  _has_bits_[0] &= ~0x00000002u;
}
inline void WorldBossRpcWorldBossRankInfoAsk::clear_occupation() {
  occupation_ = -1;
  clear_has_occupation();
}
inline ::google::protobuf::int32 WorldBossRpcWorldBossRankInfoAsk::occupation() const {
  return occupation_;
}
inline void WorldBossRpcWorldBossRankInfoAsk::set_occupation(::google::protobuf::int32 value) {
  set_has_occupation();
  occupation_ = value;
}

// -------------------------------------------------------------------

// WorldBossRpcWorldBossRankInfoReply

// optional int32 Result = 1 [default = -1];
inline bool WorldBossRpcWorldBossRankInfoReply::has_result() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void WorldBossRpcWorldBossRankInfoReply::set_has_result() {
  _has_bits_[0] |= 0x00000001u;
}
inline void WorldBossRpcWorldBossRankInfoReply::clear_has_result() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void WorldBossRpcWorldBossRankInfoReply::clear_result() {
  result_ = -1;
  clear_has_result();
}
inline ::google::protobuf::int32 WorldBossRpcWorldBossRankInfoReply::result() const {
  return result_;
}
inline void WorldBossRpcWorldBossRankInfoReply::set_result(::google::protobuf::int32 value) {
  set_has_result();
  result_ = value;
}

// repeated .WorldBossRankInfo RankInfo = 2;
inline int WorldBossRpcWorldBossRankInfoReply::rankinfo_size() const {
  return rankinfo_.size();
}
inline void WorldBossRpcWorldBossRankInfoReply::clear_rankinfo() {
  rankinfo_.Clear();
}
inline const ::WorldBossRankInfo& WorldBossRpcWorldBossRankInfoReply::rankinfo(int index) const {
  return rankinfo_.Get(index);
}
inline ::WorldBossRankInfo* WorldBossRpcWorldBossRankInfoReply::mutable_rankinfo(int index) {
  return rankinfo_.Mutable(index);
}
inline ::WorldBossRankInfo* WorldBossRpcWorldBossRankInfoReply::add_rankinfo() {
  return rankinfo_.Add();
}
inline const ::google::protobuf::RepeatedPtrField< ::WorldBossRankInfo >&
WorldBossRpcWorldBossRankInfoReply::rankinfo() const {
  return rankinfo_;
}
inline ::google::protobuf::RepeatedPtrField< ::WorldBossRankInfo >*
WorldBossRpcWorldBossRankInfoReply::mutable_rankinfo() {
  return &rankinfo_;
}

// optional string LastKillName = 3;
inline bool WorldBossRpcWorldBossRankInfoReply::has_lastkillname() const {
  return (_has_bits_[0] & 0x00000004u) != 0;
}
inline void WorldBossRpcWorldBossRankInfoReply::set_has_lastkillname() {
  _has_bits_[0] |= 0x00000004u;
}
inline void WorldBossRpcWorldBossRankInfoReply::clear_has_lastkillname() {
  _has_bits_[0] &= ~0x00000004u;
}
inline void WorldBossRpcWorldBossRankInfoReply::clear_lastkillname() {
  if (lastkillname_ != &::google::protobuf::internal::kEmptyString) {
    lastkillname_->clear();
  }
  clear_has_lastkillname();
}
inline const ::std::string& WorldBossRpcWorldBossRankInfoReply::lastkillname() const {
  return *lastkillname_;
}
inline void WorldBossRpcWorldBossRankInfoReply::set_lastkillname(const ::std::string& value) {
  set_has_lastkillname();
  if (lastkillname_ == &::google::protobuf::internal::kEmptyString) {
    lastkillname_ = new ::std::string;
  }
  lastkillname_->assign(value);
}
inline void WorldBossRpcWorldBossRankInfoReply::set_lastkillname(const char* value) {
  set_has_lastkillname();
  if (lastkillname_ == &::google::protobuf::internal::kEmptyString) {
    lastkillname_ = new ::std::string;
  }
  lastkillname_->assign(value);
}
inline void WorldBossRpcWorldBossRankInfoReply::set_lastkillname(const char* value, size_t size) {
  set_has_lastkillname();
  if (lastkillname_ == &::google::protobuf::internal::kEmptyString) {
    lastkillname_ = new ::std::string;
  }
  lastkillname_->assign(reinterpret_cast<const char*>(value), size);
}
inline ::std::string* WorldBossRpcWorldBossRankInfoReply::mutable_lastkillname() {
  set_has_lastkillname();
  if (lastkillname_ == &::google::protobuf::internal::kEmptyString) {
    lastkillname_ = new ::std::string;
  }
  return lastkillname_;
}
inline ::std::string* WorldBossRpcWorldBossRankInfoReply::release_lastkillname() {
  clear_has_lastkillname();
  if (lastkillname_ == &::google::protobuf::internal::kEmptyString) {
    return NULL;
  } else {
    ::std::string* temp = lastkillname_;
    lastkillname_ = const_cast< ::std::string*>(&::google::protobuf::internal::kEmptyString);
    return temp;
  }
}
inline void WorldBossRpcWorldBossRankInfoReply::set_allocated_lastkillname(::std::string* lastkillname) {
  if (lastkillname_ != &::google::protobuf::internal::kEmptyString) {
    delete lastkillname_;
  }
  if (lastkillname) {
    set_has_lastkillname();
    lastkillname_ = lastkillname;
  } else {
    clear_has_lastkillname();
    lastkillname_ = const_cast< ::std::string*>(&::google::protobuf::internal::kEmptyString);
  }
}

// optional string MaxDamageName = 4;
inline bool WorldBossRpcWorldBossRankInfoReply::has_maxdamagename() const {
  return (_has_bits_[0] & 0x00000008u) != 0;
}
inline void WorldBossRpcWorldBossRankInfoReply::set_has_maxdamagename() {
  _has_bits_[0] |= 0x00000008u;
}
inline void WorldBossRpcWorldBossRankInfoReply::clear_has_maxdamagename() {
  _has_bits_[0] &= ~0x00000008u;
}
inline void WorldBossRpcWorldBossRankInfoReply::clear_maxdamagename() {
  if (maxdamagename_ != &::google::protobuf::internal::kEmptyString) {
    maxdamagename_->clear();
  }
  clear_has_maxdamagename();
}
inline const ::std::string& WorldBossRpcWorldBossRankInfoReply::maxdamagename() const {
  return *maxdamagename_;
}
inline void WorldBossRpcWorldBossRankInfoReply::set_maxdamagename(const ::std::string& value) {
  set_has_maxdamagename();
  if (maxdamagename_ == &::google::protobuf::internal::kEmptyString) {
    maxdamagename_ = new ::std::string;
  }
  maxdamagename_->assign(value);
}
inline void WorldBossRpcWorldBossRankInfoReply::set_maxdamagename(const char* value) {
  set_has_maxdamagename();
  if (maxdamagename_ == &::google::protobuf::internal::kEmptyString) {
    maxdamagename_ = new ::std::string;
  }
  maxdamagename_->assign(value);
}
inline void WorldBossRpcWorldBossRankInfoReply::set_maxdamagename(const char* value, size_t size) {
  set_has_maxdamagename();
  if (maxdamagename_ == &::google::protobuf::internal::kEmptyString) {
    maxdamagename_ = new ::std::string;
  }
  maxdamagename_->assign(reinterpret_cast<const char*>(value), size);
}
inline ::std::string* WorldBossRpcWorldBossRankInfoReply::mutable_maxdamagename() {
  set_has_maxdamagename();
  if (maxdamagename_ == &::google::protobuf::internal::kEmptyString) {
    maxdamagename_ = new ::std::string;
  }
  return maxdamagename_;
}
inline ::std::string* WorldBossRpcWorldBossRankInfoReply::release_maxdamagename() {
  clear_has_maxdamagename();
  if (maxdamagename_ == &::google::protobuf::internal::kEmptyString) {
    return NULL;
  } else {
    ::std::string* temp = maxdamagename_;
    maxdamagename_ = const_cast< ::std::string*>(&::google::protobuf::internal::kEmptyString);
    return temp;
  }
}
inline void WorldBossRpcWorldBossRankInfoReply::set_allocated_maxdamagename(::std::string* maxdamagename) {
  if (maxdamagename_ != &::google::protobuf::internal::kEmptyString) {
    delete maxdamagename_;
  }
  if (maxdamagename) {
    set_has_maxdamagename();
    maxdamagename_ = maxdamagename;
  } else {
    clear_has_maxdamagename();
    maxdamagename_ = const_cast< ::std::string*>(&::google::protobuf::internal::kEmptyString);
  }
}

// optional int32 MyRank = 5 [default = -1];
inline bool WorldBossRpcWorldBossRankInfoReply::has_myrank() const {
  return (_has_bits_[0] & 0x00000010u) != 0;
}
inline void WorldBossRpcWorldBossRankInfoReply::set_has_myrank() {
  _has_bits_[0] |= 0x00000010u;
}
inline void WorldBossRpcWorldBossRankInfoReply::clear_has_myrank() {
  _has_bits_[0] &= ~0x00000010u;
}
inline void WorldBossRpcWorldBossRankInfoReply::clear_myrank() {
  myrank_ = -1;
  clear_has_myrank();
}
inline ::google::protobuf::int32 WorldBossRpcWorldBossRankInfoReply::myrank() const {
  return myrank_;
}
inline void WorldBossRpcWorldBossRankInfoReply::set_myrank(::google::protobuf::int32 value) {
  set_has_myrank();
  myrank_ = value;
}

// optional int32 Occupation = 6 [default = -1];
inline bool WorldBossRpcWorldBossRankInfoReply::has_occupation() const {
  return (_has_bits_[0] & 0x00000020u) != 0;
}
inline void WorldBossRpcWorldBossRankInfoReply::set_has_occupation() {
  _has_bits_[0] |= 0x00000020u;
}
inline void WorldBossRpcWorldBossRankInfoReply::clear_has_occupation() {
  _has_bits_[0] &= ~0x00000020u;
}
inline void WorldBossRpcWorldBossRankInfoReply::clear_occupation() {
  occupation_ = -1;
  clear_has_occupation();
}
inline ::google::protobuf::int32 WorldBossRpcWorldBossRankInfoReply::occupation() const {
  return occupation_;
}
inline void WorldBossRpcWorldBossRankInfoReply::set_occupation(::google::protobuf::int32 value) {
  set_has_occupation();
  occupation_ = value;
}

// optional int32 BossID = 7 [default = -1];
inline bool WorldBossRpcWorldBossRankInfoReply::has_bossid() const {
  return (_has_bits_[0] & 0x00000040u) != 0;
}
inline void WorldBossRpcWorldBossRankInfoReply::set_has_bossid() {
  _has_bits_[0] |= 0x00000040u;
}
inline void WorldBossRpcWorldBossRankInfoReply::clear_has_bossid() {
  _has_bits_[0] &= ~0x00000040u;
}
inline void WorldBossRpcWorldBossRankInfoReply::clear_bossid() {
  bossid_ = -1;
  clear_has_bossid();
}
inline ::google::protobuf::int32 WorldBossRpcWorldBossRankInfoReply::bossid() const {
  return bossid_;
}
inline void WorldBossRpcWorldBossRankInfoReply::set_bossid(::google::protobuf::int32 value) {
  set_has_bossid();
  bossid_ = value;
}

// optional int32 MyOccupationRank = 8 [default = -1];
inline bool WorldBossRpcWorldBossRankInfoReply::has_myoccupationrank() const {
  return (_has_bits_[0] & 0x00000080u) != 0;
}
inline void WorldBossRpcWorldBossRankInfoReply::set_has_myoccupationrank() {
  _has_bits_[0] |= 0x00000080u;
}
inline void WorldBossRpcWorldBossRankInfoReply::clear_has_myoccupationrank() {
  _has_bits_[0] &= ~0x00000080u;
}
inline void WorldBossRpcWorldBossRankInfoReply::clear_myoccupationrank() {
  myoccupationrank_ = -1;
  clear_has_myoccupationrank();
}
inline ::google::protobuf::int32 WorldBossRpcWorldBossRankInfoReply::myoccupationrank() const {
  return myoccupationrank_;
}
inline void WorldBossRpcWorldBossRankInfoReply::set_myoccupationrank(::google::protobuf::int32 value) {
  set_has_myoccupationrank();
  myoccupationrank_ = value;
}

// optional int32 MyScore = 9 [default = -1];
inline bool WorldBossRpcWorldBossRankInfoReply::has_myscore() const {
  return (_has_bits_[0] & 0x00000100u) != 0;
}
inline void WorldBossRpcWorldBossRankInfoReply::set_has_myscore() {
  _has_bits_[0] |= 0x00000100u;
}
inline void WorldBossRpcWorldBossRankInfoReply::clear_has_myscore() {
  _has_bits_[0] &= ~0x00000100u;
}
inline void WorldBossRpcWorldBossRankInfoReply::clear_myscore() {
  myscore_ = -1;
  clear_has_myscore();
}
inline ::google::protobuf::int32 WorldBossRpcWorldBossRankInfoReply::myscore() const {
  return myscore_;
}
inline void WorldBossRpcWorldBossRankInfoReply::set_myscore(::google::protobuf::int32 value) {
  set_has_myscore();
  myscore_ = value;
}


// @@protoc_insertion_point(namespace_scope)

#ifndef SWIG
namespace google {
namespace protobuf {


}  // namespace google
}  // namespace protobuf
#endif  // SWIG

// @@protoc_insertion_point(global_scope)

#endif  // PROTOBUF_WorldBossRpc_2eproto__INCLUDED
