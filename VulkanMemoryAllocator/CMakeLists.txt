# CMakeList.txt : CMake project for VulkanMemoryAllocator, include source and define
# project specific logic here.
#
cmake_minimum_required (VERSION 3.8)

# Add source to this project's executable.
set(CMAKE_ARCHIVE_OUTPUT_DIRECTORY ${CMAKE_CURRENT_SOURCE_DIR}/..)
set(CMAKE_LIBRARY_OUTPUT_DIRECTORY ${CMAKE_CURRENT_SOURCE_DIR}/..)
set(CMAKE_RUNTIME_OUTPUT_DIRECTORY ${CMAKE_CURRENT_SOURCE_DIR}/..)

find_package(Vulkan REQUIRED)
add_library (VulkanMemoryAllocator SHARED "VulkanMemoryAllocator.cpp" "VulkanMemoryAllocator.h" "vk_mem_alloc.h")
target_include_directories(VulkanMemoryAllocator PRIVATE Vulkan::Vulkan)
target_link_libraries(VulkanMemoryAllocator Vulkan::Vulkan)
# TODO: Add tests and install targets if needed.
