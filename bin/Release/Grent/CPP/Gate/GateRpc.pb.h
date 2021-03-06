// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: GateRpc.proto

#ifndef PROTOBUF_GateRpc_2eproto__INCLUDED
#define PROTOBUF_GateRpc_2eproto__INCLUDED

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
void  protobuf_AddDesc_GateRpc_2eproto();
void protobuf_AssignDesc_GateRpc_2eproto();
void protobuf_ShutdownFile_GateRpc_2eproto();

class GateRpcPingAsk;
class GateRpcPingReply;

// ===================================================================

class GateRpcPingAsk : public ::google::protobuf::Message {
 public:
  GateRpcPingAsk();
  virtual ~GateRpcPingAsk();

  GateRpcPingAsk(const GateRpcPingAsk& from);

  inline GateRpcPingAsk& operator=(const GateRpcPingAsk& from) {
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
  static const GateRpcPingAsk& default_instance();

  void Swap(GateRpcPingAsk* other);

  // implements Message ----------------------------------------------

  GateRpcPingAsk* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const GateRpcPingAsk& from);
  void MergeFrom(const GateRpcPingAsk& from);
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

  // optional uint64 Sequence = 1 [default = 0];
  inline bool has_sequence() const;
  inline void clear_sequence();
  static const int kSequenceFieldNumber = 1;
  inline ::google::protobuf::uint64 sequence() const;
  inline void set_sequence(::google::protobuf::uint64 value);

  // @@protoc_insertion_point(class_scope:GateRpcPingAsk)
 private:
  inline void set_has_sequence();
  inline void clear_has_sequence();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::uint64 sequence_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(1 + 31) / 32];

  friend void  protobuf_AddDesc_GateRpc_2eproto();
  friend void protobuf_AssignDesc_GateRpc_2eproto();
  friend void protobuf_ShutdownFile_GateRpc_2eproto();

  void InitAsDefaultInstance();
  static GateRpcPingAsk* default_instance_;
};
// -------------------------------------------------------------------

class GateRpcPingReply : public ::google::protobuf::Message {
 public:
  GateRpcPingReply();
  virtual ~GateRpcPingReply();

  GateRpcPingReply(const GateRpcPingReply& from);

  inline GateRpcPingReply& operator=(const GateRpcPingReply& from) {
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
  static const GateRpcPingReply& default_instance();

  void Swap(GateRpcPingReply* other);

  // implements Message ----------------------------------------------

  GateRpcPingReply* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const GateRpcPingReply& from);
  void MergeFrom(const GateRpcPingReply& from);
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

  // optional uint64 Sequence = 2 [default = 0];
  inline bool has_sequence() const;
  inline void clear_sequence();
  static const int kSequenceFieldNumber = 2;
  inline ::google::protobuf::uint64 sequence() const;
  inline void set_sequence(::google::protobuf::uint64 value);

  // @@protoc_insertion_point(class_scope:GateRpcPingReply)
 private:
  inline void set_has_result();
  inline void clear_has_result();
  inline void set_has_sequence();
  inline void clear_has_sequence();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::uint64 sequence_;
  ::google::protobuf::int32 result_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(2 + 31) / 32];

  friend void  protobuf_AddDesc_GateRpc_2eproto();
  friend void protobuf_AssignDesc_GateRpc_2eproto();
  friend void protobuf_ShutdownFile_GateRpc_2eproto();

  void InitAsDefaultInstance();
  static GateRpcPingReply* default_instance_;
};
// ===================================================================


// ===================================================================

// GateRpcPingAsk

// optional uint64 Sequence = 1 [default = 0];
inline bool GateRpcPingAsk::has_sequence() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void GateRpcPingAsk::set_has_sequence() {
  _has_bits_[0] |= 0x00000001u;
}
inline void GateRpcPingAsk::clear_has_sequence() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void GateRpcPingAsk::clear_sequence() {
  sequence_ = GOOGLE_ULONGLONG(0);
  clear_has_sequence();
}
inline ::google::protobuf::uint64 GateRpcPingAsk::sequence() const {
  return sequence_;
}
inline void GateRpcPingAsk::set_sequence(::google::protobuf::uint64 value) {
  set_has_sequence();
  sequence_ = value;
}

// -------------------------------------------------------------------

// GateRpcPingReply

// optional int32 Result = 1 [default = -1];
inline bool GateRpcPingReply::has_result() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void GateRpcPingReply::set_has_result() {
  _has_bits_[0] |= 0x00000001u;
}
inline void GateRpcPingReply::clear_has_result() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void GateRpcPingReply::clear_result() {
  result_ = -1;
  clear_has_result();
}
inline ::google::protobuf::int32 GateRpcPingReply::result() const {
  return result_;
}
inline void GateRpcPingReply::set_result(::google::protobuf::int32 value) {
  set_has_result();
  result_ = value;
}

// optional uint64 Sequence = 2 [default = 0];
inline bool GateRpcPingReply::has_sequence() const {
  return (_has_bits_[0] & 0x00000002u) != 0;
}
inline void GateRpcPingReply::set_has_sequence() {
  _has_bits_[0] |= 0x00000002u;
}
inline void GateRpcPingReply::clear_has_sequence() {
  _has_bits_[0] &= ~0x00000002u;
}
inline void GateRpcPingReply::clear_sequence() {
  sequence_ = GOOGLE_ULONGLONG(0);
  clear_has_sequence();
}
inline ::google::protobuf::uint64 GateRpcPingReply::sequence() const {
  return sequence_;
}
inline void GateRpcPingReply::set_sequence(::google::protobuf::uint64 value) {
  set_has_sequence();
  sequence_ = value;
}


// @@protoc_insertion_point(namespace_scope)

#ifndef SWIG
namespace google {
namespace protobuf {


}  // namespace google
}  // namespace protobuf
#endif  // SWIG

// @@protoc_insertion_point(global_scope)

#endif  // PROTOBUF_GateRpc_2eproto__INCLUDED
