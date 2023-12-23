LOCAL_PATH := $(call my-dir)/../

LOCAL_SHORT_COMMANDS := true

include $(LOCAL_PATH)/Makefile.srcs

include $(CLEAR_VARS)
LOCAL_MODULE       := FreeImageShared
LOCAL_C_INCLUDES   := $(LOCAL_PATH)/Source \
                        $(LOCAL_PATH)/Source/Metadata \
                        $(LOCAL_PATH)/Source/FreeImageToolkit \
                        $(LOCAL_PATH)/Source/LibJPEG \
                        $(LOCAL_PATH)/Source/LibPNG \
                        $(LOCAL_PATH)/Source/LibTIFF4 \
                        $(LOCAL_PATH)/Source/ZLib \
                        $(LOCAL_PATH)/Source/LibOpenJPEG \
                        $(LOCAL_PATH)/Source/OpenEXR \
                        $(LOCAL_PATH)/Source/OpenEXR/Half \
                        $(LOCAL_PATH)/Source/OpenEXR/Iex \
                        $(LOCAL_PATH)/Source/OpenEXR/IexMath \
                        $(LOCAL_PATH)/Source/OpenEXR/IlmImf \
                        $(LOCAL_PATH)/Source/OpenEXR/IlmThread \
                        $(LOCAL_PATH)/Source/OpenEXR/Imath \
                        $(LOCAL_PATH)/Source/LibRawLite \
                        $(LOCAL_PATH)/Source/LibRawLite/dcraw \
                        $(LOCAL_PATH)/Source/LibRawLite/internal \
                        $(LOCAL_PATH)/Source/LibRawLite/libraw \
                        $(LOCAL_PATH)/Source/LibRawLite/src \
						$(LOCAL_PATH)/Source/LibJXR/jxrgluelib \
						$(LOCAL_PATH)/Source/LibJXR/image/sys \
						$(LOCAL_PATH)/Source/LibJXR/image/x86 \
						$(LOCAL_PATH)/Source/LibJXR/image/encode \
						$(LOCAL_PATH)/Source/LibJXR/image/decode \
						$(LOCAL_PATH)/Source/LibJXR/common/include \
                        $(LOCAL_PATH)/Source/LibWebP \
                        $(LOCAL_PATH)/Source/LibWebP/src/dec \
                        $(LOCAL_PATH)/Source/LibWebP/src/dsp \
                        $(LOCAL_PATH)/Source/LibWebP/src/enc \
                        $(LOCAL_PATH)/Source/LibWebP/src/mux \
                        $(LOCAL_PATH)/Source/LibWebP/src/utils \
                        $(LOCAL_PATH)/Source/LibWebP/src/webp \
                        $(LOCAL_PATH)/Source/Missing
#LOCAL_SRC_FILES    := $(SRCS) ./Source/Missing/swab.cpp
LOCAL_CPP_FEATURES := rtti exceptions
LOCAL_CFLAGS       := -O3 -fPIC -D__ANSI__ -DDISABLE_PERF_MEASUREMENT
include $(BUILD_SHARED_LIBRARY)
#include $(BUILD_STATIC_LIBRARY)

#include $(CLEAR_VARS)
#LOCAL_MODULE           := FreeImageShared
#LOCAL_STATIC_LIBRARIES := FreeImage
#include $(BUILD_SHARED_LIBRARY)