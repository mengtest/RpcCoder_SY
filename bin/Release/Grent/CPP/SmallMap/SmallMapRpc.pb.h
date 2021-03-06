// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: SmallMapRpc.proto

#ifndef PROTOBUF_SmallMapRpc_2eproto__INCLUDED
#define PROTOBUF_SmallMapRpc_2eproto__INCLUDED

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
void  protobuf_AddDesc_SmallMapRpc_2eproto();
void protobuf_AssignDesc_SmallMapRpc_2eproto();
void protobuf_ShutdownFile_SmallMapRpc_2eproto();

class SmallMapRpcNewObjNotify;
class SmallMapRpcDelObjNotify;

// ===================================================================

class SmallMapRpcNewObjNotify : public ::google::protobuf::Message {
 public:
  SmallMapRpcNewObjNotify();
  virtual ~SmallMapRpcNewObjNotify();

  SmallMapRpcNewObjNotify(const SmallMapRpcNewObjNotify& from);

  inline SmallMapRpcNewObjNotify& operator=(const SmallMapRpcNewObjNotify& from) {
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
  static const SmallMapRpcNewObjNotify& default_instance();

  void Swap(SmallMapRpcNewObjNotify* other);

  // implements Message ----------------------------------------------

  SmallMapRpcNewObjNotify* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const SmallMapRpcNewObjNotify& from);
  void MergeFrom(const SmallMapRpcNewObjNotify& from);
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

  // optional int32 ObjId = 2 [default = -1];
  inline bool has_objid() const;
  inline void clear_objid();
  static const int kObjIdFieldNumber = 2;
  inline ::google::protobuf::int32 objid() const;
  inline void set_objid(::google::protobuf::int32 value);

  // optional int32 DataId = 3 [default = -1];
  inline bool has_dataid() const;
  inline void clear_dataid();
  static const int kDataIdFieldNumber = 3;
  inline ::google::protobuf::int32 dataid() const;
  inline void set_dataid(::google::protobuf::int32 value);

  // optional .Vector3 WorldPos = 4;
  inline bool has_worldpos() const;
  inline void clear_worldpos();
  static const int kWorldPosFieldNumber = 4;
  inline const ::Vector3& worldpos() const;
  inline ::Vector3* mutable_worldpos();
  inline ::Vector3* release_worldpos();
  inline void set_allocated_worldpos(::Vector3* worldpos);

  // @@protoc_insertion_point(class_scope:SmallMapRpcNewObjNotify)
 private:
  inline void set_has_objid();
  inline void clear_has_objid();
  inline void set_has_dataid();
  inline void clear_has_dataid();
  inline void set_has_worldpos();
  inline void clear_has_worldpos();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::int32 objid_;
  ::google::protobuf::int32 dataid_;
  ::Vector3* worldpos_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(3 + 31) / 32];

  friend void  protobuf_AddDesc_SmallMapRpc_2eproto();
  friend void protobuf_AssignDesc_SmallMapRpc_2eproto();
  friend void protobuf_ShutdownFile_SmallMapRpc_2eproto();

  void InitAsDefaultInstance();
  static SmallMapRpcNewObjNotify* default_instance_;
};
// -------------------------------------------------------------------

class SmallMapRpcDelObjNotify : public ::google::protobuf::Message {
 public:
  SmallMapRpcDelObjNotify();
  virtual ~SmallMapRpcDelObjNotify();

  SmallMapRpcDelObjNotify(const SmallMapRpcDelObjNotify& from);

  inline SmallMapRpcDelObjNotify& operator=(const SmallMapRpcDelObjNotify& from) {
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
  static const SmallMapRpcDelObjNotify& default_instance();

  void Swap(SmallMapRpcDelObjNotify* other);

  // implements Message ----------------------------------------------

  SmallMapRpcDelObjNotify* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const SmallMapRpcDelObjNotify& from);
  void MergeFrom(const SmallMapRpcDelObjNotify& from);
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

  // optional int32 ObjId = 1 [default = -1];
  inline bool has_objid() const;
  inline void clear_objid();
  static const int kObjIdFieldNumber = 1;
  inline ::google::protobuf::int32 objid() const;
  inline void set_objid(::google::protobuf::int32 value);

  // @@protoc_insertion_point(class_scope:SmallMapRpcDelObjNotify)
 private:
  inline void set_has_objid();
  inline void clear_has_objid();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::int32 objid_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(1 + 31) / 32];

  friend void  protobuf_AddDesc_SmallMapRpc_2eproto();
  friend void protobuf_AssignDesc_SmallMapRpc_2eproto();
  friend void protobuf_ShutdownFile_SmallMapRpc_2eproto();

  void InitAsDefaultInstance();
  static SmallMapRpcDelObjNotify* default_instance_;
};
// ===================================================================


// ===================================================================

// SmallMapRpcNewObjNotify

// optional int32 ObjId = 2 [default = -1];
inline bool SmallMapRpcNewObjNotify::has_objid() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void SmallMapRpcNewObjNotify::set_has_objid() {
  _has_bits_[0] |= 0x00000001u;
}
inline void SmallMapRpcNewObjNotify::clear_has_objid() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void SmallMapRpcNewObjNotify::clear_objid() {
  objid_ = -1;
  clear_has_objid();
}
inline ::google::protobuf::int32 SmallMapRpcNewObjNotify::objid() const {
  return objid_;
}
inline void SmallMapRpcNewObjNotify::set_objid(::google::protobuf::int32 value) {
  set_has_objid();
  objid_ = value;
}

// optional int32 DataId = 3 [default = -1];
inline bool SmallMapRpcNewObjNotify::has_dataid() const {
  return (_has_bits_[0] & 0x00000002u) != 0;
}
inline void SmallMapRpcNewObjNotify::set_has_dataid() {
  _has_bits_[0] |= 0x00000002u;
}
inline void SmallMapRpcNewObjNotify::clear_has_dataid() {
  _has_bits_[0] &= ~0x00000002u;
}
inline void SmallMapRpcNewObjNotify::clear_dataid() {
  dataid_ = -1;
  clear_has_dataid();
}
inline ::google::protobuf::int32 SmallMapRpcNewObjNotify::dataid() const {
  return dataid_;
}
inline void SmallMapRpcNewObjNotify::set_dataid(::google::protobuf::int32 value) {
  set_has_dataid();
  dataid_ = value;
}

// optional .Vector3 WorldPos = 4;
inline bool SmallMapRpcNewObjNotify::has_worldpos() const {
  return (_has_bits_[0] & 0x00000004u) != 0;
}
inline void SmallMapRpcNewObjNotify::set_has_worldpos() {
  _has_bits_[0] |= 0x00000004u;
}
inline void SmallMapRpcNewObjNotify::clear_has_worldpos() {
  _has_bits_[0] &= ~0x00000004u;
}
inline void SmallMapRpcNewObjNotify::clear_worldpos() {
  if (worldpos_ != NULL) worldpos_->::Vector3::Clear();
  clear_has_worldpos();
}
inline const ::Vector3& SmallMapRpcNewObjNotify::worldpos() const {
  return worldpos_ != NULL ? *worldpos_ : *default_instance_->worldpos_;
}
inline ::Vector3* SmallMapRpcNewObjNotify::mutable_worldpos() {
  set_has_worldpos();
  if (worldpos_ == NULL) worldpos_ = new ::Vector3;
  return worldpos_;
}
inline ::Vector3* SmallMapRpcNewObjNotify::release_worldpos() {
  clear_has_worldpos();
  ::Vector3* temp = worldpos_;
  worldpos_ = NULL;
  return temp;
}
inline void SmallMapRpcNewObjNotify::set_allocated_worldpos(::Vector3* worldpos) {
  delete worldpos_;
  worldpos_ = worldpos;
  if (worldpos) {
    set_has_worldpos();
  } else {
    clear_has_worldpos();
  }
}

// -------------------------------------------------------------------

// SmallMapRpcDelObjNotify

// optional int32 ObjId = 1 [default = -1];
inline bool SmallMapRpcDelObjNotify::has_objid() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void SmallMapRpcDelObjNotify::set_has_objid() {
  _has_bits_[0] |= 0x00000001u;
}
inline void SmallMapRpcDelObjNotify::clear_has_objid() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void SmallMapRpcDelObjNotify::clear_objid() {
  objid_ = -1;
  clear_has_objid();
}
inline ::google::protobuf::int32 SmallMapRpcDelObjNotify::objid() const {
  return objid_;
}
inline void SmallMapRpcDelObjNotify::set_objid(::google::protobuf::int32 value) {
  set_has_objid();
  objid_ = value;
}


// @@protoc_insertion_point(namespace_scope)

#ifndef SWIG
namespace google {
namespace protobuf {


}  // namespace google
}  // namespace protobuf
#endif  // SWIG

// @@protoc_insertion_point(global_scope)

#endif  // PROTOBUF_SmallMapRpc_2eproto__INCLUDED
