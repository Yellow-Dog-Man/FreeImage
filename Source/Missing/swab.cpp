#include <unistd.h>

void swab(const void* void_src, void* void_dst, ssize_t byte_count) {
  const uint8_t* src = static_cast<const uint8_t*>(void_src);
  uint8_t* dst = static_cast<uint8_t*>(void_dst);
  while (byte_count > 1) {
    uint8_t x = *src++;
    uint8_t y = *src++;
    *dst++ = y;
    *dst++ = x;
    byte_count -= 2;
  }
}