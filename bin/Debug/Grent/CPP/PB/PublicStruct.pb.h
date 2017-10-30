// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: PublicStruct.proto

#ifndef PROTOBUF_PublicStruct_2eproto__INCLUDED
#define PROTOBUF_PublicStruct_2eproto__INCLUDED

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
// @@protoc_insertion_point(includes)

// Internal implementation detail -- do not call these.
void  protobuf_AddDesc_PublicStruct_2eproto();
void protobuf_AssignDesc_PublicStruct_2eproto();
void protobuf_ShutdownFile_PublicStruct_2eproto();

class CharacterInfo;

// ===================================================================

class CharacterInfo : public ::google::protobuf::Message {
 public:
  CharacterInfo();
  virtual ~CharacterInfo();

  CharacterInfo(const CharacterInfo& from);

  inline CharacterInfo& operator=(const CharacterInfo& from) {
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
  static const CharacterInfo& default_instance();

  void Swap(CharacterInfo* other);

  // implements Message ----------------------------------------------

  CharacterInfo* New() const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const CharacterInfo& from);
  void MergeFrom(const CharacterInfo& from);
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

  // optional uint64 RoleId = 1 [default = 0];
  inline bool has_roleid() const;
  inline void clear_roleid();
  static const int kRoleIdFieldNumber = 1;
  inline ::google::protobuf::uint64 roleid() const;
  inline void set_roleid(::google::protobuf::uint64 value);

  // optional string Nickname = 2;
  inline bool has_nickname() const;
  inline void clear_nickname();
  static const int kNicknameFieldNumber = 2;
  inline const ::std::string& nickname() const;
  inline void set_nickname(const ::std::string& value);
  inline void set_nickname(const char* value);
  inline void set_nickname(const char* value, size_t size);
  inline ::std::string* mutable_nickname();
  inline ::std::string* release_nickname();
  inline void set_allocated_nickname(::std::string* nickname);

  // optional sint32 ConfigId = 3 [default = -1];
  inline bool has_configid() const;
  inline void clear_configid();
  static const int kConfigIdFieldNumber = 3;
  inline ::google::protobuf::int32 configid() const;
  inline void set_configid(::google::protobuf::int32 value);

  // @@protoc_insertion_point(class_scope:CharacterInfo)
 private:
  inline void set_has_roleid();
  inline void clear_has_roleid();
  inline void set_has_nickname();
  inline void clear_has_nickname();
  inline void set_has_configid();
  inline void clear_has_configid();

  ::google::protobuf::UnknownFieldSet _unknown_fields_;

  ::google::protobuf::uint64 roleid_;
  ::std::string* nickname_;
  ::google::protobuf::int32 configid_;

  mutable int _cached_size_;
  ::google::protobuf::uint32 _has_bits_[(3 + 31) / 32];

  friend void  protobuf_AddDesc_PublicStruct_2eproto();
  friend void protobuf_AssignDesc_PublicStruct_2eproto();
  friend void protobuf_ShutdownFile_PublicStruct_2eproto();

  void InitAsDefaultInstance();
  static CharacterInfo* default_instance_;
};
// ===================================================================


// ===================================================================

// CharacterInfo

// optional uint64 RoleId = 1 [default = 0];
inline bool CharacterInfo::has_roleid() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void CharacterInfo::set_has_roleid() {
  _has_bits_[0] |= 0x00000001u;
}
inline void CharacterInfo::clear_has_roleid() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void CharacterInfo::clear_roleid() {
  roleid_ = GOOGLE_ULONGLONG(0);
  clear_has_roleid();
}
inline ::google::protobuf::uint64 CharacterInfo::roleid() const {
  return roleid_;
}
inline void CharacterInfo::set_roleid(::google::protobuf::uint64 value) {
  set_has_roleid();
  roleid_ = value;
}

// optional string Nickname = 2;
inline bool CharacterInfo::has_nickname() const {
  return (_has_bits_[0] & 0x00000002u) != 0;
}
inline void CharacterInfo::set_has_nickname() {
  _has_bits_[0] |= 0x00000002u;
}
inline void CharacterInfo::clear_has_nickname() {
  _has_bits_[0] &= ~0x00000002u;
}
inline void CharacterInfo::clear_nickname() {
  if (nickname_ != &::google::protobuf::internal::kEmptyString) {
    nickname_->clear();
  }
  clear_has_nickname();
}
inline const ::std::string& CharacterInfo::nickname() const {
  return *nickname_;
}
inline void CharacterInfo::set_nickname(const ::std::string& value) {
  set_has_nickname();
  if (nickname_ == &::google::protobuf::internal::kEmptyString) {
    nickname_ = new ::std::string;
  }
  nickname_->assign(value);
}
inline void CharacterInfo::set_nickname(const char* value) {
  set_has_nickname();
  if (nickname_ == &::google::protobuf::internal::kEmptyString) {
    nickname_ = new ::std::string;
  }
  nickname_->assign(value);
}
inline void CharacterInfo::set_nickname(const char* value, size_t size) {
  set_has_nickname();
  if (nickname_ == &::google::protobuf::internal::kEmptyString) {
    nickname_ = new ::std::string;
  }
  nickname_->assign(reinterpret_cast<const char*>(value), size);
}
inline ::std::string* CharacterInfo::mutable_nickname() {
  set_has_nickname();
  if (nickname_ == &::google::protobuf::internal::kEmptyString) {
    nickname_ = new ::std::string;
  }
  return nickname_;
}
inline ::std::string* CharacterInfo::release_nickname() {
  clear_has_nickname();
  if (nickname_ == &::google::protobuf::internal::kEmptyString) {
    return NULL;
  } else {
    ::std::string* temp = nickname_;
    nickname_ = const_cast< ::std::string*>(&::google::protobuf::internal::kEmptyString);
    return temp;
  }
}
inline void CharacterInfo::set_allocated_nickname(::std::string* nickname) {
  if (nickname_ != &::google::protobuf::internal::kEmptyString) {
    delete nickname_;
  }
  if (nickname) {
    set_has_nickname();
    nickname_ = nickname;
  } else {
    clear_has_nickname();
    nickname_ = const_cast< ::std::string*>(&::google::protobuf::internal::kEmptyString);
  }
}

// optional sint32 ConfigId = 3 [default = -1];
inline bool CharacterInfo::has_configid() const {
  return (_has_bits_[0] & 0x00000004u) != 0;
}
inline void CharacterInfo::set_has_configid() {
  _has_bits_[0] |= 0x00000004u;
}
inline void CharacterInfo::clear_has_configid() {
  _has_bits_[0] &= ~0x00000004u;
}
inline void CharacterInfo::clear_configid() {
  configid_ = -1;
  clear_has_configid();
}
inline ::google::protobuf::int32 CharacterInfo::configid() const {
  return configid_;
}
inline void CharacterInfo::set_configid(::google::protobuf::int32 value) {
  set_has_configid();
  configid_ = value;
}


// @@protoc_insertion_point(namespace_scope)

#ifndef SWIG
namespace google {
namespace protobuf {


}  // namespace google
}  // namespace protobuf
#endif  // SWIG

// @@protoc_insertion_point(global_scope)

#endif  // PROTOBUF_PublicStruct_2eproto__INCLUDED