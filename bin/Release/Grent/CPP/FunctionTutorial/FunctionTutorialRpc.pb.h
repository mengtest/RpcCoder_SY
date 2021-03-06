// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: FunctionTutorialRpc.proto

#ifndef PROTOBUF_FunctionTutorialRpc_2eproto__INCLUDED
#define PROTOBUF_FunctionTutorialRpc_2eproto__INCLUDED

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
void  protobuf_AddDesc_FunctionTutorialRpc_2eproto();
void protobuf_AssignDesc_FunctionTutorialRpc_2eproto();
void protobuf_ShutdownFile_FunctionTutorialRpc_2eproto();

class FunctionTutorialRpcSyncFunctionStepAsk;
class FunctionTutorialRpcSyncFunctionStepReply;
class FunctionTutorialRpcFinishStepAsk;
class FunctionTutorialRpcFinishStepReply;
class FunctionTutorialRpcActiveStepAsk;
class FunctionTutorialRpcActiveStepReply;

// ===================================================================

class FunctionTutorialRpcSyncFunctionStepAsk : public ::google::protobuf::Message {
 public:
  FunctionTutorialRpcSyncFunctionStepAsk();
  virtual ~FunctionTutorialRpcSyncFunctionStepAsk();

  FunctionTutorialRpcSyncFunctionStepAsk(const FunctionTutorialRpcSyncFunctionStepAsk& from);

  inline FunctionTutorialRpcSyncFunctionStepAsk& operator=(const FunctionTutorialRpcSyncFunctionStepAsk& from) {
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
  static const FunctionTutorialRpcSyncFunctionStepAsk& default_instance();

  void Swap(FunctionTutorialRpcSyncFunctionStepAsk* other);

  // implements Message ----------------------------------------------

  FunctionTutorialRpcSyncFunctionStepAsk* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const FunctionTutorialRpcSyncFunctionStepAsk& from);
  void MergeFrom(const FunctionTutorialRpcSyncFunctionStepAsk& from);
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

  // @@protoc_insertion_point(class_scope:FunctionTutorialRpcSyncFunctionStepAsk)
 private:

  ::google::protobuf::UnknownFieldSet _unknown_fields_;


  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[1];

  friend void  protobuf_AddDesc_FunctionTutorialRpc_2eproto();
  friend void protobuf_AssignDesc_FunctionTutorialRpc_2eproto();
  friend void protobuf_ShutdownFile_FunctionTutorialRpc_2eproto();

  void InitAsDefaultInstance();
  static FunctionTutorialRpcSyncFunctionStepAsk* default_instance_;
};
// -------------------------------------------------------------------

class FunctionTutorialRpcSyncFunctionStepReply : public ::google::protobuf::Message {
 public:
  FunctionTutorialRpcSyncFunctionStepReply();
  virtual ~FunctionTutorialRpcSyncFunctionStepReply();

  FunctionTutorialRpcSyncFunctionStepReply(const FunctionTutorialRpcSyncFunctionStepReply& from);

  inline FunctionTutorialRpcSyncFunctionStepReply& operator=(const FunctionTutorialRpcSyncFunctionStepReply& from) {
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
  static const FunctionTutorialRpcSyncFunctionStepReply& default_instance();

  void Swap(FunctionTutorialRpcSyncFunctionStepReply* other);

  // implements Message ----------------------------------------------

  FunctionTutorialRpcSyncFunctionStepReply* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const FunctionTutorialRpcSyncFunctionStepReply& from);
  void MergeFrom(const FunctionTutorialRpcSyncFunctionStepReply& from);
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

  // repeated int32 FunctionList = 2;
  inline int functionlist_size() const;
  inline void clear_functionlist();
  static const int kFunctionListFieldNumber = 2;
  inline ::google::protobuf::int32 functionlist(int index) const;
  inline void set_functionlist(int index, ::google::protobuf::int32 value);
  inline void add_functionlist(::google::protobuf::int32 value);
  inline const ::google::protobuf::RepeatedField< ::google::protobuf::int32 >&
      functionlist() const;
  inline ::google::protobuf::RepeatedField< ::google::protobuf::int32 >*
      mutable_functionlist();

  // repeated int32 ActiveFunctionList = 3;
  inline int activefunctionlist_size() const;
  inline void clear_activefunctionlist();
  static const int kActiveFunctionListFieldNumber = 3;
  inline ::google::protobuf::int32 activefunctionlist(int index) const;
  inline void set_activefunctionlist(int index, ::google::protobuf::int32 value);
  inline void add_activefunctionlist(::google::protobuf::int32 value);
  inline const ::google::protobuf::RepeatedField< ::google::protobuf::int32 >&
      activefunctionlist() const;
  inline ::google::protobuf::RepeatedField< ::google::protobuf::int32 >*
      mutable_activefunctionlist();

  // @@protoc_insertion_point(class_scope:FunctionTutorialRpcSyncFunctionStepReply)
 private:
  inline void set_has_result();
  inline void clear_has_result();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::RepeatedField< ::google::protobuf::int32 > functionlist_;
  ::google::protobuf::RepeatedField< ::google::protobuf::int32 > activefunctionlist_;
  ::google::protobuf::int32 result_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(3 + 31) / 32];

  friend void  protobuf_AddDesc_FunctionTutorialRpc_2eproto();
  friend void protobuf_AssignDesc_FunctionTutorialRpc_2eproto();
  friend void protobuf_ShutdownFile_FunctionTutorialRpc_2eproto();

  void InitAsDefaultInstance();
  static FunctionTutorialRpcSyncFunctionStepReply* default_instance_;
};
// -------------------------------------------------------------------

class FunctionTutorialRpcFinishStepAsk : public ::google::protobuf::Message {
 public:
  FunctionTutorialRpcFinishStepAsk();
  virtual ~FunctionTutorialRpcFinishStepAsk();

  FunctionTutorialRpcFinishStepAsk(const FunctionTutorialRpcFinishStepAsk& from);

  inline FunctionTutorialRpcFinishStepAsk& operator=(const FunctionTutorialRpcFinishStepAsk& from) {
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
  static const FunctionTutorialRpcFinishStepAsk& default_instance();

  void Swap(FunctionTutorialRpcFinishStepAsk* other);

  // implements Message ----------------------------------------------

  FunctionTutorialRpcFinishStepAsk* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const FunctionTutorialRpcFinishStepAsk& from);
  void MergeFrom(const FunctionTutorialRpcFinishStepAsk& from);
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

  // optional int32 FunctionID = 1 [default = -1];
  inline bool has_functionid() const;
  inline void clear_functionid();
  static const int kFunctionIDFieldNumber = 1;
  inline ::google::protobuf::int32 functionid() const;
  inline void set_functionid(::google::protobuf::int32 value);

  // @@protoc_insertion_point(class_scope:FunctionTutorialRpcFinishStepAsk)
 private:
  inline void set_has_functionid();
  inline void clear_has_functionid();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::int32 functionid_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(1 + 31) / 32];

  friend void  protobuf_AddDesc_FunctionTutorialRpc_2eproto();
  friend void protobuf_AssignDesc_FunctionTutorialRpc_2eproto();
  friend void protobuf_ShutdownFile_FunctionTutorialRpc_2eproto();

  void InitAsDefaultInstance();
  static FunctionTutorialRpcFinishStepAsk* default_instance_;
};
// -------------------------------------------------------------------

class FunctionTutorialRpcFinishStepReply : public ::google::protobuf::Message {
 public:
  FunctionTutorialRpcFinishStepReply();
  virtual ~FunctionTutorialRpcFinishStepReply();

  FunctionTutorialRpcFinishStepReply(const FunctionTutorialRpcFinishStepReply& from);

  inline FunctionTutorialRpcFinishStepReply& operator=(const FunctionTutorialRpcFinishStepReply& from) {
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
  static const FunctionTutorialRpcFinishStepReply& default_instance();

  void Swap(FunctionTutorialRpcFinishStepReply* other);

  // implements Message ----------------------------------------------

  FunctionTutorialRpcFinishStepReply* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const FunctionTutorialRpcFinishStepReply& from);
  void MergeFrom(const FunctionTutorialRpcFinishStepReply& from);
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

  // optional int32 FunctionID = 3 [default = -1];
  inline bool has_functionid() const;
  inline void clear_functionid();
  static const int kFunctionIDFieldNumber = 3;
  inline ::google::protobuf::int32 functionid() const;
  inline void set_functionid(::google::protobuf::int32 value);

  // @@protoc_insertion_point(class_scope:FunctionTutorialRpcFinishStepReply)
 private:
  inline void set_has_result();
  inline void clear_has_result();
  inline void set_has_functionid();
  inline void clear_has_functionid();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::int32 result_;
  ::google::protobuf::int32 functionid_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(2 + 31) / 32];

  friend void  protobuf_AddDesc_FunctionTutorialRpc_2eproto();
  friend void protobuf_AssignDesc_FunctionTutorialRpc_2eproto();
  friend void protobuf_ShutdownFile_FunctionTutorialRpc_2eproto();

  void InitAsDefaultInstance();
  static FunctionTutorialRpcFinishStepReply* default_instance_;
};
// -------------------------------------------------------------------

class FunctionTutorialRpcActiveStepAsk : public ::google::protobuf::Message {
 public:
  FunctionTutorialRpcActiveStepAsk();
  virtual ~FunctionTutorialRpcActiveStepAsk();

  FunctionTutorialRpcActiveStepAsk(const FunctionTutorialRpcActiveStepAsk& from);

  inline FunctionTutorialRpcActiveStepAsk& operator=(const FunctionTutorialRpcActiveStepAsk& from) {
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
  static const FunctionTutorialRpcActiveStepAsk& default_instance();

  void Swap(FunctionTutorialRpcActiveStepAsk* other);

  // implements Message ----------------------------------------------

  FunctionTutorialRpcActiveStepAsk* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const FunctionTutorialRpcActiveStepAsk& from);
  void MergeFrom(const FunctionTutorialRpcActiveStepAsk& from);
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

  // optional int32 FunctionID = 1 [default = -1];
  inline bool has_functionid() const;
  inline void clear_functionid();
  static const int kFunctionIDFieldNumber = 1;
  inline ::google::protobuf::int32 functionid() const;
  inline void set_functionid(::google::protobuf::int32 value);

  // @@protoc_insertion_point(class_scope:FunctionTutorialRpcActiveStepAsk)
 private:
  inline void set_has_functionid();
  inline void clear_has_functionid();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::int32 functionid_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(1 + 31) / 32];

  friend void  protobuf_AddDesc_FunctionTutorialRpc_2eproto();
  friend void protobuf_AssignDesc_FunctionTutorialRpc_2eproto();
  friend void protobuf_ShutdownFile_FunctionTutorialRpc_2eproto();

  void InitAsDefaultInstance();
  static FunctionTutorialRpcActiveStepAsk* default_instance_;
};
// -------------------------------------------------------------------

class FunctionTutorialRpcActiveStepReply : public ::google::protobuf::Message {
 public:
  FunctionTutorialRpcActiveStepReply();
  virtual ~FunctionTutorialRpcActiveStepReply();

  FunctionTutorialRpcActiveStepReply(const FunctionTutorialRpcActiveStepReply& from);

  inline FunctionTutorialRpcActiveStepReply& operator=(const FunctionTutorialRpcActiveStepReply& from) {
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
  static const FunctionTutorialRpcActiveStepReply& default_instance();

  void Swap(FunctionTutorialRpcActiveStepReply* other);

  // implements Message ----------------------------------------------

  FunctionTutorialRpcActiveStepReply* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const FunctionTutorialRpcActiveStepReply& from);
  void MergeFrom(const FunctionTutorialRpcActiveStepReply& from);
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

  // optional int32 FunctionID = 2 [default = -1];
  inline bool has_functionid() const;
  inline void clear_functionid();
  static const int kFunctionIDFieldNumber = 2;
  inline ::google::protobuf::int32 functionid() const;
  inline void set_functionid(::google::protobuf::int32 value);

  // @@protoc_insertion_point(class_scope:FunctionTutorialRpcActiveStepReply)
 private:
  inline void set_has_result();
  inline void clear_has_result();
  inline void set_has_functionid();
  inline void clear_has_functionid();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::int32 result_;
  ::google::protobuf::int32 functionid_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(2 + 31) / 32];

  friend void  protobuf_AddDesc_FunctionTutorialRpc_2eproto();
  friend void protobuf_AssignDesc_FunctionTutorialRpc_2eproto();
  friend void protobuf_ShutdownFile_FunctionTutorialRpc_2eproto();

  void InitAsDefaultInstance();
  static FunctionTutorialRpcActiveStepReply* default_instance_;
};
// ===================================================================


// ===================================================================

// FunctionTutorialRpcSyncFunctionStepAsk

// -------------------------------------------------------------------

// FunctionTutorialRpcSyncFunctionStepReply

// optional int32 Result = 1 [default = -1];
inline bool FunctionTutorialRpcSyncFunctionStepReply::has_result() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void FunctionTutorialRpcSyncFunctionStepReply::set_has_result() {
  _has_bits_[0] |= 0x00000001u;
}
inline void FunctionTutorialRpcSyncFunctionStepReply::clear_has_result() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void FunctionTutorialRpcSyncFunctionStepReply::clear_result() {
  result_ = -1;
  clear_has_result();
}
inline ::google::protobuf::int32 FunctionTutorialRpcSyncFunctionStepReply::result() const {
  return result_;
}
inline void FunctionTutorialRpcSyncFunctionStepReply::set_result(::google::protobuf::int32 value) {
  set_has_result();
  result_ = value;
}

// repeated int32 FunctionList = 2;
inline int FunctionTutorialRpcSyncFunctionStepReply::functionlist_size() const {
  return functionlist_.size();
}
inline void FunctionTutorialRpcSyncFunctionStepReply::clear_functionlist() {
  functionlist_.Clear();
}
inline ::google::protobuf::int32 FunctionTutorialRpcSyncFunctionStepReply::functionlist(int index) const {
  return functionlist_.Get(index);
}
inline void FunctionTutorialRpcSyncFunctionStepReply::set_functionlist(int index, ::google::protobuf::int32 value) {
  functionlist_.Set(index, value);
}
inline void FunctionTutorialRpcSyncFunctionStepReply::add_functionlist(::google::protobuf::int32 value) {
  functionlist_.Add(value);
}
inline const ::google::protobuf::RepeatedField< ::google::protobuf::int32 >&
FunctionTutorialRpcSyncFunctionStepReply::functionlist() const {
  return functionlist_;
}
inline ::google::protobuf::RepeatedField< ::google::protobuf::int32 >*
FunctionTutorialRpcSyncFunctionStepReply::mutable_functionlist() {
  return &functionlist_;
}

// repeated int32 ActiveFunctionList = 3;
inline int FunctionTutorialRpcSyncFunctionStepReply::activefunctionlist_size() const {
  return activefunctionlist_.size();
}
inline void FunctionTutorialRpcSyncFunctionStepReply::clear_activefunctionlist() {
  activefunctionlist_.Clear();
}
inline ::google::protobuf::int32 FunctionTutorialRpcSyncFunctionStepReply::activefunctionlist(int index) const {
  return activefunctionlist_.Get(index);
}
inline void FunctionTutorialRpcSyncFunctionStepReply::set_activefunctionlist(int index, ::google::protobuf::int32 value) {
  activefunctionlist_.Set(index, value);
}
inline void FunctionTutorialRpcSyncFunctionStepReply::add_activefunctionlist(::google::protobuf::int32 value) {
  activefunctionlist_.Add(value);
}
inline const ::google::protobuf::RepeatedField< ::google::protobuf::int32 >&
FunctionTutorialRpcSyncFunctionStepReply::activefunctionlist() const {
  return activefunctionlist_;
}
inline ::google::protobuf::RepeatedField< ::google::protobuf::int32 >*
FunctionTutorialRpcSyncFunctionStepReply::mutable_activefunctionlist() {
  return &activefunctionlist_;
}

// -------------------------------------------------------------------

// FunctionTutorialRpcFinishStepAsk

// optional int32 FunctionID = 1 [default = -1];
inline bool FunctionTutorialRpcFinishStepAsk::has_functionid() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void FunctionTutorialRpcFinishStepAsk::set_has_functionid() {
  _has_bits_[0] |= 0x00000001u;
}
inline void FunctionTutorialRpcFinishStepAsk::clear_has_functionid() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void FunctionTutorialRpcFinishStepAsk::clear_functionid() {
  functionid_ = -1;
  clear_has_functionid();
}
inline ::google::protobuf::int32 FunctionTutorialRpcFinishStepAsk::functionid() const {
  return functionid_;
}
inline void FunctionTutorialRpcFinishStepAsk::set_functionid(::google::protobuf::int32 value) {
  set_has_functionid();
  functionid_ = value;
}

// -------------------------------------------------------------------

// FunctionTutorialRpcFinishStepReply

// optional int32 Result = 1 [default = -1];
inline bool FunctionTutorialRpcFinishStepReply::has_result() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void FunctionTutorialRpcFinishStepReply::set_has_result() {
  _has_bits_[0] |= 0x00000001u;
}
inline void FunctionTutorialRpcFinishStepReply::clear_has_result() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void FunctionTutorialRpcFinishStepReply::clear_result() {
  result_ = -1;
  clear_has_result();
}
inline ::google::protobuf::int32 FunctionTutorialRpcFinishStepReply::result() const {
  return result_;
}
inline void FunctionTutorialRpcFinishStepReply::set_result(::google::protobuf::int32 value) {
  set_has_result();
  result_ = value;
}

// optional int32 FunctionID = 3 [default = -1];
inline bool FunctionTutorialRpcFinishStepReply::has_functionid() const {
  return (_has_bits_[0] & 0x00000002u) != 0;
}
inline void FunctionTutorialRpcFinishStepReply::set_has_functionid() {
  _has_bits_[0] |= 0x00000002u;
}
inline void FunctionTutorialRpcFinishStepReply::clear_has_functionid() {
  _has_bits_[0] &= ~0x00000002u;
}
inline void FunctionTutorialRpcFinishStepReply::clear_functionid() {
  functionid_ = -1;
  clear_has_functionid();
}
inline ::google::protobuf::int32 FunctionTutorialRpcFinishStepReply::functionid() const {
  return functionid_;
}
inline void FunctionTutorialRpcFinishStepReply::set_functionid(::google::protobuf::int32 value) {
  set_has_functionid();
  functionid_ = value;
}

// -------------------------------------------------------------------

// FunctionTutorialRpcActiveStepAsk

// optional int32 FunctionID = 1 [default = -1];
inline bool FunctionTutorialRpcActiveStepAsk::has_functionid() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void FunctionTutorialRpcActiveStepAsk::set_has_functionid() {
  _has_bits_[0] |= 0x00000001u;
}
inline void FunctionTutorialRpcActiveStepAsk::clear_has_functionid() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void FunctionTutorialRpcActiveStepAsk::clear_functionid() {
  functionid_ = -1;
  clear_has_functionid();
}
inline ::google::protobuf::int32 FunctionTutorialRpcActiveStepAsk::functionid() const {
  return functionid_;
}
inline void FunctionTutorialRpcActiveStepAsk::set_functionid(::google::protobuf::int32 value) {
  set_has_functionid();
  functionid_ = value;
}

// -------------------------------------------------------------------

// FunctionTutorialRpcActiveStepReply

// optional int32 Result = 1 [default = -1];
inline bool FunctionTutorialRpcActiveStepReply::has_result() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void FunctionTutorialRpcActiveStepReply::set_has_result() {
  _has_bits_[0] |= 0x00000001u;
}
inline void FunctionTutorialRpcActiveStepReply::clear_has_result() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void FunctionTutorialRpcActiveStepReply::clear_result() {
  result_ = -1;
  clear_has_result();
}
inline ::google::protobuf::int32 FunctionTutorialRpcActiveStepReply::result() const {
  return result_;
}
inline void FunctionTutorialRpcActiveStepReply::set_result(::google::protobuf::int32 value) {
  set_has_result();
  result_ = value;
}

// optional int32 FunctionID = 2 [default = -1];
inline bool FunctionTutorialRpcActiveStepReply::has_functionid() const {
  return (_has_bits_[0] & 0x00000002u) != 0;
}
inline void FunctionTutorialRpcActiveStepReply::set_has_functionid() {
  _has_bits_[0] |= 0x00000002u;
}
inline void FunctionTutorialRpcActiveStepReply::clear_has_functionid() {
  _has_bits_[0] &= ~0x00000002u;
}
inline void FunctionTutorialRpcActiveStepReply::clear_functionid() {
  functionid_ = -1;
  clear_has_functionid();
}
inline ::google::protobuf::int32 FunctionTutorialRpcActiveStepReply::functionid() const {
  return functionid_;
}
inline void FunctionTutorialRpcActiveStepReply::set_functionid(::google::protobuf::int32 value) {
  set_has_functionid();
  functionid_ = value;
}


// @@protoc_insertion_point(namespace_scope)

#ifndef SWIG
namespace google {
namespace protobuf {


}  // namespace google
}  // namespace protobuf
#endif  // SWIG

// @@protoc_insertion_point(global_scope)

#endif  // PROTOBUF_FunctionTutorialRpc_2eproto__INCLUDED
