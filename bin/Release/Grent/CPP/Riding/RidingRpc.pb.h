// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: RidingRpc.proto

#ifndef PROTOBUF_RidingRpc_2eproto__INCLUDED
#define PROTOBUF_RidingRpc_2eproto__INCLUDED

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
void  protobuf_AddDesc_RidingRpc_2eproto();
void protobuf_AssignDesc_RidingRpc_2eproto();
void protobuf_ShutdownFile_RidingRpc_2eproto();

class RidingRpcRidingAsk;
class RidingRpcRidingReply;
class RidingRpcUnRidingAsk;
class RidingRpcUnRidingReply;

// ===================================================================

class RidingRpcRidingAsk : public ::google::protobuf::Message {
 public:
  RidingRpcRidingAsk();
  virtual ~RidingRpcRidingAsk();

  RidingRpcRidingAsk(const RidingRpcRidingAsk& from);

  inline RidingRpcRidingAsk& operator=(const RidingRpcRidingAsk& from) {
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
  static const RidingRpcRidingAsk& default_instance();

  void Swap(RidingRpcRidingAsk* other);

  // implements Message ----------------------------------------------

  RidingRpcRidingAsk* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const RidingRpcRidingAsk& from);
  void MergeFrom(const RidingRpcRidingAsk& from);
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

  // @@protoc_insertion_point(class_scope:RidingRpcRidingAsk)
 private:

  ::google::protobuf::UnknownFieldSet _unknown_fields_;


  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[1];

  friend void  protobuf_AddDesc_RidingRpc_2eproto();
  friend void protobuf_AssignDesc_RidingRpc_2eproto();
  friend void protobuf_ShutdownFile_RidingRpc_2eproto();

  void InitAsDefaultInstance();
  static RidingRpcRidingAsk* default_instance_;
};
// -------------------------------------------------------------------

class RidingRpcRidingReply : public ::google::protobuf::Message {
 public:
  RidingRpcRidingReply();
  virtual ~RidingRpcRidingReply();

  RidingRpcRidingReply(const RidingRpcRidingReply& from);

  inline RidingRpcRidingReply& operator=(const RidingRpcRidingReply& from) {
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
  static const RidingRpcRidingReply& default_instance();

  void Swap(RidingRpcRidingReply* other);

  // implements Message ----------------------------------------------

  RidingRpcRidingReply* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const RidingRpcRidingReply& from);
  void MergeFrom(const RidingRpcRidingReply& from);
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

  // @@protoc_insertion_point(class_scope:RidingRpcRidingReply)
 private:
  inline void set_has_result();
  inline void clear_has_result();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::int32 result_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(1 + 31) / 32];

  friend void  protobuf_AddDesc_RidingRpc_2eproto();
  friend void protobuf_AssignDesc_RidingRpc_2eproto();
  friend void protobuf_ShutdownFile_RidingRpc_2eproto();

  void InitAsDefaultInstance();
  static RidingRpcRidingReply* default_instance_;
};
// -------------------------------------------------------------------

class RidingRpcUnRidingAsk : public ::google::protobuf::Message {
 public:
  RidingRpcUnRidingAsk();
  virtual ~RidingRpcUnRidingAsk();

  RidingRpcUnRidingAsk(const RidingRpcUnRidingAsk& from);

  inline RidingRpcUnRidingAsk& operator=(const RidingRpcUnRidingAsk& from) {
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
  static const RidingRpcUnRidingAsk& default_instance();

  void Swap(RidingRpcUnRidingAsk* other);

  // implements Message ----------------------------------------------

  RidingRpcUnRidingAsk* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const RidingRpcUnRidingAsk& from);
  void MergeFrom(const RidingRpcUnRidingAsk& from);
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

  // @@protoc_insertion_point(class_scope:RidingRpcUnRidingAsk)
 private:

  ::google::protobuf::UnknownFieldSet _unknown_fields_;


  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[1];

  friend void  protobuf_AddDesc_RidingRpc_2eproto();
  friend void protobuf_AssignDesc_RidingRpc_2eproto();
  friend void protobuf_ShutdownFile_RidingRpc_2eproto();

  void InitAsDefaultInstance();
  static RidingRpcUnRidingAsk* default_instance_;
};
// -------------------------------------------------------------------

class RidingRpcUnRidingReply : public ::google::protobuf::Message {
 public:
  RidingRpcUnRidingReply();
  virtual ~RidingRpcUnRidingReply();

  RidingRpcUnRidingReply(const RidingRpcUnRidingReply& from);

  inline RidingRpcUnRidingReply& operator=(const RidingRpcUnRidingReply& from) {
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
  static const RidingRpcUnRidingReply& default_instance();

  void Swap(RidingRpcUnRidingReply* other);

  // implements Message ----------------------------------------------

  RidingRpcUnRidingReply* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const RidingRpcUnRidingReply& from);
  void MergeFrom(const RidingRpcUnRidingReply& from);
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

  // @@protoc_insertion_point(class_scope:RidingRpcUnRidingReply)
 private:
  inline void set_has_result();
  inline void clear_has_result();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::int32 result_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(1 + 31) / 32];

  friend void  protobuf_AddDesc_RidingRpc_2eproto();
  friend void protobuf_AssignDesc_RidingRpc_2eproto();
  friend void protobuf_ShutdownFile_RidingRpc_2eproto();

  void InitAsDefaultInstance();
  static RidingRpcUnRidingReply* default_instance_;
};
// ===================================================================


// ===================================================================

// RidingRpcRidingAsk

// -------------------------------------------------------------------

// RidingRpcRidingReply

// optional int32 Result = 1 [default = -1];
inline bool RidingRpcRidingReply::has_result() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void RidingRpcRidingReply::set_has_result() {
  _has_bits_[0] |= 0x00000001u;
}
inline void RidingRpcRidingReply::clear_has_result() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void RidingRpcRidingReply::clear_result() {
  result_ = -1;
  clear_has_result();
}
inline ::google::protobuf::int32 RidingRpcRidingReply::result() const {
  return result_;
}
inline void RidingRpcRidingReply::set_result(::google::protobuf::int32 value) {
  set_has_result();
  result_ = value;
}

// -------------------------------------------------------------------

// RidingRpcUnRidingAsk

// -------------------------------------------------------------------

// RidingRpcUnRidingReply

// optional int32 Result = 1 [default = -1];
inline bool RidingRpcUnRidingReply::has_result() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void RidingRpcUnRidingReply::set_has_result() {
  _has_bits_[0] |= 0x00000001u;
}
inline void RidingRpcUnRidingReply::clear_has_result() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void RidingRpcUnRidingReply::clear_result() {
  result_ = -1;
  clear_has_result();
}
inline ::google::protobuf::int32 RidingRpcUnRidingReply::result() const {
  return result_;
}
inline void RidingRpcUnRidingReply::set_result(::google::protobuf::int32 value) {
  set_has_result();
  result_ = value;
}


// @@protoc_insertion_point(namespace_scope)

#ifndef SWIG
namespace google {
namespace protobuf {


}  // namespace google
}  // namespace protobuf
#endif  // SWIG

// @@protoc_insertion_point(global_scope)

#endif  // PROTOBUF_RidingRpc_2eproto__INCLUDED
